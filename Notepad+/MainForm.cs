using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Formatting;
using ScintillaNET;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Notepad_
{
    // Из основного функционала нет возможности открытия документа в новом окне.
    // Из дополнительного функционала не реализована компиляция кода.

    public partial class MainForm : Form
    {
        static RichTextBox currentTextBox;

        static TabControl currentTabControl;

        Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            // Установка минимального размера формы.
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size / 2;

            // Установка цветов приложения.
            AppSettings.ChangeBackColor(tabControl, upperMenuStrip, lowerMenuPanel, panelForPanels);
            AppSettings.ChangeFontColor(tabControl, upperMenuStrip, closeButton);
            keyWordsStripMenuItem.BackColor = Properties.Settings.Default.keyWordsColor;
            commentsStripMenuItem.BackColor = Properties.Settings.Default.commentsColor;
            docCommentsStripMenuItem.BackColor = Properties.Settings.Default.commentDocColor;
            stringsStripMenuItem.BackColor = Properties.Settings.Default.stringColor;
            operatorsStripMenuItem.BackColor = Properties.Settings.Default.operatorsColor;
            //Открытие незакрытых файлов.
            TabsManager.OpenUnclosedFiles(tabControl);
            if (tabControl.TabPages.Count != 0)
                currentTextBox = (RichTextBox)tabControl.SelectedTab.Controls[0];
            currentTabControl = tabControl;

            // Добавление контекстного меню.
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                tabControl.TabPages[i].Controls[0].ContextMenuStrip = contextMenuStrip;
                if (tabControl.TabPages[i].Controls[0].HasChildren)
                    tabControl.TabPages[i].Controls[0].Controls[0].ContextMenuStrip = contextMenuStrip;
            }
            // Запуск таймера.
            switch (Properties.Settings.Default.timeInterval)
            {
                case (15000): Every15secondsStripMenuItem_Click(null, null); break;
                case (60000): EveryMinuteStripMenuItem_Click(null, null); break;
                case (300000): Every5MinutesMenuItem_Click(null, null); break;
                case (1800000): Every30MinutesStripMenuItem_Click(null, null); break;
                case (3600000): EveryHourStripMenuItem_Click(null, null); break;
            }
            timer.Enabled = true;
            if (Properties.Settings.Default.isAutosaveEnabled) TurnOnSavingMenuItem_Click(null, null);
            if (Properties.Settings.Default.isLoggingEnabled) TurnOnLoggingMenuItem_Click(null, null);
        }


        #region fileToolStripMenuItem events

        /// <summary>
        /// Создание нового файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Title = "Укажите путь к файлу",
                FileName = "newFile",
                Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|cs files (*.cs)|*.cs",
                //RestoreDirectory = true,
            };
            if ((saveFileDialog.ShowDialog() == DialogResult.Cancel) || (saveFileDialog.FileName.Length <= 0)) return;
            try
            {
                string filename = saveFileDialog.FileName;
                // Проверка, что такой файл еще не открыт в программе.
                if ((tabControl.TabPages != null) && (TabsManager.IsThisPageOpen(filename, tabControl)))
                {
                    MessageBox.Show("Этот файл уже открыт!");
                    return;
                }
                TabPage newPage = TabsManager.CreateTabPage(saveFileDialog.FileName);

                // Добавление вкладки на форму.
                tabControl.Controls.Add(newPage);
                tabControl.SelectedTab = tabControl.TabPages[newPage.Name];
                tabControl.SelectedTab.Controls[0].ContextMenuStrip = contextMenuStrip;
                currentTextBox = (RichTextBox)tabControl.SelectedTab.Controls[0];

                // Изменение видимости кнопок стиля шрифта.
                bool visibility = tabControl.SelectedTab != null ? GetVisibility(tabControl) : true;
                boldButton.Visible = visibility;
                italicButton.Visible = visibility;
                strikeoutButton.Visible = visibility;
                underlineButton.Visible = visibility;
                formatContextMenuItem.Visible = visibility;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод, возвращающий значение видимости кнопок стиля шрифта.
        /// </summary>
        /// <param name="tabControl"></param>
        /// <returns></returns>
        static bool GetVisibility(TabControl tabControl)
        {
            return Path.GetExtension(tabControl.SelectedTab.Name) == ".cs" ? false : true;
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|cs files (*.cs)|*.cs";

            if ((openFileDialog.ShowDialog() == DialogResult.Cancel) || (openFileDialog.FileName.Length <= 0)) return;
            try
            {
                // Проверка, что такой файл еще не открыт в программе.
                if ((tabControl.TabPages != null) && (TabsManager.IsThisPageOpen(openFileDialog.FileName, tabControl)))
                {
                    MessageBox.Show("Этот файл уже открыт!");
                    return;
                }
                string filepath = openFileDialog.FileName;

                TabPage newPage = TabsManager.CreateTabPage(filepath, true);

                // Добавление вкладки на форму.
                tabControl.Controls.Add(newPage);
                tabControl.SelectedTab = tabControl.TabPages[newPage.Name];
                tabControl.SelectedTab.Controls[0].ContextMenuStrip = contextMenuStrip;
                currentTextBox = (RichTextBox)tabControl.SelectedTab.Controls[0];

                // Изменение видимости кнопок стиля шрифта.
                bool visibility = tabControl.SelectedTab != null ? GetVisibility(tabControl) : true;
                boldButton.Visible = visibility;
                italicButton.Visible = visibility;
                strikeoutButton.Visible = visibility;
                underlineButton.Visible = visibility;
                formatContextMenuItem.Visible = visibility;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Сохранение файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            // Путь к сохраняемому файлу.
            string filepath = tabControl.SelectedTab.Name;
            try
            {
                if (!File.Exists(filepath))
                {
                    var fileStream = File.Create(filepath);
                    fileStream.Close();
                }
                SaveFile(filepath, tabControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод, сохраняющий файл.
        /// </summary>
        /// <param name="filepath"> Путь сохраняемого файла. </param>
        /// <param name="tabControl"> Панель вкладок. </param>
        static void SaveFile(string filepath, TabControl tabControl)
        {
            if (Path.GetExtension(filepath) == ".rtf")
            {
                currentTextBox.SaveFile(filepath, RichTextBoxStreamType.RichText);
            }
            else if (Path.GetExtension(filepath) == ".cs")
            {
                File.WriteAllText(filepath, tabControl.SelectedTab.Controls[0].Controls[0].Text);
            }
            else
                currentTextBox.SaveFile(filepath, RichTextBoxStreamType.PlainText);
        }

        /// <summary>
        /// Сохранение нового файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            try
            {
                string currentFileName = tabControl.SelectedTab.Name;
                string fileExtension = Path.GetExtension(currentFileName);

                var saveFileDialog = new SaveFileDialog
                {
                    FileName = Path.GetFileName(currentFileName),
                    Filter = $"{fileExtension} files (*{fileExtension})|*{fileExtension}",
                    //RestoreDirectory = true 
                };

                if ((saveFileDialog.ShowDialog() == DialogResult.Cancel) || (saveFileDialog.FileName.Length <= 0)) return;

                string newFileName = saveFileDialog.FileName;
                // Проверка, что файл с сохраняемым названием уже не открыт в программе.
                if (TabsManager.IsThisPageOpen(newFileName, tabControl) && (currentFileName != newFileName))
                {
                    MessageBox.Show("Этот файл уже открыт в программе, выберите другое имя!");
                    return;
                }
                // Сохранение файла.
                SaveFile(newFileName, tabControl);
                // Изменение параметров текущей вкладки.
                tabControl.SelectedTab.Name = newFileName;
                tabControl.SelectedTab.Text = Path.GetFileName(newFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion fileToolStripMenuItem events

        #region FontStyle changings

        /// <summary>
        /// Сделать текст жирным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            try
            {
                FontStyle currentFontStyle = currentTextBox.SelectionFont.Style;

                // Изменение стиля текста.
                if ((currentFontStyle & FontStyle.Bold) == FontStyle.Bold)
                {
                    FontStyle newFontStyle = AppSettings.DeleteFontStyle(currentFontStyle, "bold");
                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, newFontStyle);
                }
                else
                {
                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, currentFontStyle | FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoldContextMenuItem_Click(object sender, EventArgs e) => BoldButton_Click(null, null);

        /// <summary>
        /// Сделать текст курсивным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            try
            {
                FontStyle currentFontStyle = currentTextBox.SelectionFont.Style;

                // Изменение стиля текста.
                if ((currentFontStyle & FontStyle.Italic) == FontStyle.Italic)
                {
                    FontStyle newFontStyle = AppSettings.DeleteFontStyle(currentFontStyle, "italic");
                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, newFontStyle);
                }
                else
                {
                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, currentFontStyle | FontStyle.Italic);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ItalicContextMenuItem_Click(object sender, EventArgs e) => ItalicButton_Click(null, null);

        /// <summary>
        /// Сделать текст подчеркнутым.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            try
            {
                FontStyle currentFontStyle = currentTextBox.SelectionFont.Style;

                // Изменение стиля текста.
                if ((currentFontStyle & FontStyle.Underline) == FontStyle.Underline)
                {
                    FontStyle newFontStyle = AppSettings.DeleteFontStyle(currentFontStyle, "underline");
                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, newFontStyle);
                }
                else
                {

                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, currentFontStyle | FontStyle.Underline);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UnderlineContextMenuItem_Click(object sender, EventArgs e) => UnderlineButton_Click(null, null);

        /// <summary>
        /// Сделать текст зачеркнутым.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StrikeoutButton_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            try
            {
                FontStyle currentFontStyle = currentTextBox.SelectionFont.Style;

                // Изменение стиля текста.
                if ((currentFontStyle & FontStyle.Strikeout) == FontStyle.Strikeout)
                {
                    FontStyle newFontStyle = AppSettings.DeleteFontStyle(currentFontStyle, "strikeout");
                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, newFontStyle);
                }
                else
                {
                    currentTextBox.SelectionFont = new Font(currentTextBox.SelectionFont.FontFamily,
                    currentTextBox.SelectionFont.SizeInPoints, currentFontStyle | FontStyle.Strikeout);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StrikeoutContextMenuItem_Click(object sender, EventArgs e) => StrikeoutButton_Click(null, null);

        #endregion

        /// <summary>
        /// Действия при переключении вкладок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabControl.SelectedTab != null) && (tabControl.SelectedTab.Controls.Count > 0))
                currentTextBox = (RichTextBox)tabControl.SelectedTab.Controls[0];

            // Обновление таймера.
            timer.Stop();
            timer.Start();

            // Изменение видимости кнопок стиля шрифта.
            bool visibility = tabControl.SelectedTab != null ? GetVisibility(tabControl) : true;

            boldButton.Visible = visibility;
            italicButton.Visible = visibility;
            strikeoutButton.Visible = visibility;
            underlineButton.Visible = visibility;
            formatContextMenuItem.Visible = visibility;
        }

        #region editToolStripMenuItem events

        /// <summary>
        /// Выбрать весь текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            // Вырезать из кода.
            if (currentTextBox.HasChildren)
            {
                Scintilla textToCut = (Scintilla)currentTextBox.Controls[0];
                textToCut.SelectAll();
            }
            else currentTextBox.SelectAll();
        }

        private void SelectAllContextMenuItem_Click(object sender, EventArgs e) => SelectAllToolStripMenuItem_Click(null, null);


        /// <summary>
        /// Вырезать текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            // Вырезать из кода.
            if (currentTextBox.HasChildren)
            {
                Scintilla textToCut = (Scintilla)currentTextBox.Controls[0];
                textToCut.Cut();
            }
            else currentTextBox.Cut();

        }

        private void CutContextMenuItem_Click(object sender, EventArgs e) => CutToolStripMenuItem_Click(null, null);

        /// <summary>
        /// Вставить текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            // Вставить в код.
            if (currentTextBox.HasChildren)
            {
                Scintilla textToCut = (Scintilla)currentTextBox.Controls[0];
                textToCut.Paste();
            }
            else currentTextBox.Paste();
        }

        private void PasteContextMenuItem_Click(object sender, EventArgs e) => PasteToolStripMenuItem_Click(null, null);

        /// <summary>
        /// Копировать текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            // Копировать из кода.
            if (currentTextBox.HasChildren)
            {
                Scintilla textToCut = (Scintilla)currentTextBox.Controls[0];
                textToCut.Copy();
            }
            else currentTextBox.Copy();
        }

        private void CopyContextMenuItem_Click(object sender, EventArgs e) => CopyToolStripMenuItem_Click(null, null);

        /// <summary>
        /// Отменить действие.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;
            // Отмена для вкладки с кодом.
            if (currentTextBox.HasChildren)
            {
                Scintilla textToCut = (Scintilla)currentTextBox.Controls[0];
                textToCut.Undo();
            }
            else currentTextBox.Undo();
        }

        /// <summary>
        /// Повторить действие.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;
            // Повтор для вкладки с кодом.
            if (currentTextBox.HasChildren)
            {
                Scintilla textToCut = (Scintilla)currentTextBox.Controls[0];
                textToCut.Redo();
            }
            else currentTextBox.Redo();
        }

        #endregion

        /// <summary>
        /// Выбор цвета фона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackColorStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backColorDialog.ShowDialog() == DialogResult.Cancel) return;

            AppSettings.backColor = backColorDialog.Color;

            // Установка цвета фона.
            AppSettings.ChangeBackColor(tabControl, upperMenuStrip, lowerMenuPanel, panelForPanels);
        }

        /// <summary>
        /// Изменение цвета шрифта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontColorMenuItem_Click(object sender, EventArgs e)
        {
            if (fontColorDialog.ShowDialog() == DialogResult.Cancel) return;

            AppSettings.fontColor = fontColorDialog.Color;

            // Установка цвета шрифта.
            AppSettings.ChangeFontColor(tabControl, upperMenuStrip, closeButton);
        }

        #region formatToolStripMenuItem events

        /// <summary>
        /// Изменение параметров шрифта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            if (fontDialog.ShowDialog() == DialogResult.Cancel) return;

            tabControl.SelectedTab.Controls[0].Font = fontDialog.Font;
            // Изменение стиля шрифта для C# кода.
            if (tabControl.SelectedTab.Controls[0].HasChildren)
            {
                Scintilla textArea = (Scintilla)tabControl.SelectedTab.Controls[0].Controls[0];
                AppSettings.ChangeCodeFont(textArea, fontDialog.Font.Name, (int)fontDialog.Font.Size);
                AppSettings.InitSyntaxColoring(textArea);
            }
        }

        /// <summary>
        /// Метод, форматирующий C# код.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormatCodeStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;

            if (Path.GetExtension(tabControl.SelectedTab.Name) != ".cs")
            {
                MessageBox.Show("Форматирование доступно только для .cs файлов!");
                return;
            }

            try
            {
                Scintilla textArea = (Scintilla)tabControl.SelectedTab.Controls[0].Controls[0];
                Font currentFont = textArea.Font;
                int currentPosition = textArea.CurrentPosition;
                var workspace = new AdhocWorkspace();
                var tree = CSharpSyntaxTree.ParseText(textArea.Text).GetRoot();
                var formatedText = Formatter.Format(tree, workspace).ToFullString();

                // Обновление отображаемого во вкладке текста на отформатированный.
                textArea.Text = formatedText;
                // Установка параметров отображения текста с кодом.
                AppSettings.ColorizeCodeTab(textArea);
                AppSettings.ChangeCodeFont(textArea, currentFont.Name, (int)currentFont.Size);
                AppSettings.InitSyntaxColoring(textArea);
                textArea.GotoPosition(currentPosition);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Изменение цвета ключевых слов C# кода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyWordsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeColorDialog.ShowDialog() == DialogResult.Cancel) return;

            Properties.Settings.Default.keyWordsColor = keyWordsStripMenuItem.BackColor = codeColorDialog.Color;

            // Перекрашивание кода.
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Controls[0].HasChildren)
                {
                    Scintilla textArea = (Scintilla)page.Controls[0].Controls[0];
                    AppSettings.InitSyntaxColoring(textArea);
                }
            }
        }

        /// <summary>
        /// Изменение цвета комментариев C# кода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommentsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeColorDialog.ShowDialog() == DialogResult.Cancel) return;

            Properties.Settings.Default.commentsColor = commentsStripMenuItem.BackColor = codeColorDialog.Color;

            // Перекрашивание кода.
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Controls[0].HasChildren)
                {
                    Scintilla textArea = (Scintilla)page.Controls[0].Controls[0];
                    AppSettings.InitSyntaxColoring(textArea);
                }
            }
        }

        /// <summary>
        /// Изменение цвета XML-комментариев C# кода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocCommentsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeColorDialog.ShowDialog() == DialogResult.Cancel) return;

            Properties.Settings.Default.commentDocColor = docCommentsStripMenuItem.BackColor = codeColorDialog.Color;

            // Перекрашивание кода.
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Controls[0].HasChildren)
                {
                    Scintilla textArea = (Scintilla)page.Controls[0].Controls[0];
                    AppSettings.InitSyntaxColoring(textArea);
                }
            }
        }

        /// <summary>
        /// Изменение цвета операторов C# кода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeColorDialog.ShowDialog() == DialogResult.Cancel) return;

            Properties.Settings.Default.operatorsColor = operatorsStripMenuItem.BackColor = codeColorDialog.Color;

            // Перекрашивание кода.
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Controls[0].HasChildren)
                {
                    Scintilla textArea = (Scintilla)page.Controls[0].Controls[0];
                    AppSettings.InitSyntaxColoring(textArea);
                }
            }
        }

        /// <summary>
        /// Изменение цвета строк C# кода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StringsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (codeColorDialog.ShowDialog() == DialogResult.Cancel) return;

            Properties.Settings.Default.stringColor = stringsStripMenuItem.BackColor = codeColorDialog.Color;

            // Перекрашивание кода.
            foreach (TabPage page in tabControl.TabPages)
            {
                if (page.Controls[0].HasChildren)
                {
                    Scintilla textArea = (Scintilla)page.Controls[0].Controls[0];
                    AppSettings.InitSyntaxColoring(textArea);
                }
            }
        }

        #endregion

        #region Autosave

        /// <summary>
        /// Включение автосохранения каждые 15 секунд.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Every15secondsStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 15000;

            // Изменение отображения галочки во всех подменю интервала автосохранения.
            every15secondsStripMenuItem.Checked = true;
            every30MinutesStripMenuItem.Checked = false;
            everyMinuteStripMenuItem.Checked = false;
            every5MinutesMenuItem.Checked = false;
            everyHourStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Включение автосохранения каждую минуту.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EveryMinuteStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 60000;

            // Изменение отображения галочки во всех подменю интервала автосохранения.
            everyMinuteStripMenuItem.Checked = true;
            every15secondsStripMenuItem.Checked = false;
            every30MinutesStripMenuItem.Checked = false;
            every5MinutesMenuItem.Checked = false;
            everyHourStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Включение автосохранения каждые 5 минут.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Every5MinutesMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 300000;

            // Изменение отображения галочки во всех подменю интервала автосохранения.
            every5MinutesMenuItem.Checked = true;
            every15secondsStripMenuItem.Checked = false;
            everyMinuteStripMenuItem.Checked = false;
            every30MinutesStripMenuItem.Checked = false;
            everyHourStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Включение автосохранения каждые 30 минут.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Every30MinutesStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 1800000;

            // Изменение отображения галочки во всех подменю интервала автосохранения.
            every30MinutesStripMenuItem.Checked = true;
            every15secondsStripMenuItem.Checked = false;
            everyMinuteStripMenuItem.Checked = false;
            every5MinutesMenuItem.Checked = false;
            everyHourStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Включение автосохранения каждый час.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EveryHourStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Interval = 3600000;

            // Изменение отображения галочки во всех подменю интервала автосохранения.
            everyHourStripMenuItem.Checked = true;
            every15secondsStripMenuItem.Checked = false;
            everyMinuteStripMenuItem.Checked = false;
            every5MinutesMenuItem.Checked = false;
            every30MinutesStripMenuItem.Checked = false;
        }

        /// <summary>
        /// Включение автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TurnOnSavingMenuItem_Click(object sender, EventArgs e)
        {
            turnOffSavingMenuItem.Checked = false;
            turnOnSavingMenuItem.Checked = true;

            // Подписка на событие таймера.
            timer.Tick += new EventHandler(SaveToolStripMenuItem_Click);
            // Обновление таймера.
            if (!Properties.Settings.Default.isLoggingEnabled)
            {
                timer.Stop();
                timer.Start();
            }
            Properties.Settings.Default.isAutosaveEnabled = true;
        }

        /// <summary>
        /// Выключение автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TurnOffSavingMenuItem_Click(object sender, EventArgs e)
        {
            turnOffSavingMenuItem.Checked = true;
            turnOnSavingMenuItem.Checked = false;
            // Отписка от события таймера.
            timer.Tick -= new EventHandler(SaveToolStripMenuItem_Click);
            Properties.Settings.Default.isAutosaveEnabled = false;
        }

        /// <summary>
        /// Выключение журналирования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TurnOffLoggingMenuItem_Click(object sender, EventArgs e)
        {
            turnOffLoggingMenuItem.Checked = true;
            turnOnLoggingMenuItem.Checked = false;
            // Отписка от события таймера.
            timer.Tick -= Logging;
            Properties.Settings.Default.isLoggingEnabled = false;
        }

        /// <summary>
        /// Включение журналирования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TurnOnLoggingMenuItem_Click(object sender, EventArgs e)
        {
            turnOffLoggingMenuItem.Checked = false;
            turnOnLoggingMenuItem.Checked = true;
            MessageBox.Show($"Файлы будут сохраняться в скрытую папку {Application.StartupPath + "Logs"}");
            // Подписка на событие таймера.
            timer.Tick += Logging;
            // Обновление таймера.
            if (!Properties.Settings.Default.isLoggingEnabled)
            {
                timer.Stop();
                timer.Start();
            }
            Properties.Settings.Default.isLoggingEnabled = true;
        }

        /// <summary>
        /// Журналирование.
        /// </summary>
        /// <param name="filename"> Сохраняемый файл. </param>
        public static void Logging(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(currentTabControl)) return;
            try
            {
                // Создание скрытой папки.
                string directoryPath = Application.StartupPath + "Logs";
                if (!Directory.Exists(directoryPath))
                {
                    DirectoryInfo hiddenDirectory = Directory.CreateDirectory(directoryPath);
                    hiddenDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
                else

                    File.SetAttributes(directoryPath, FileAttributes.Hidden);

                string filename = currentTabControl.SelectedTab.Text;
                string dateFormat = DateTime.Now.ToString("HH-mm-ss_dd-MM-yyyy", CultureInfo.InvariantCulture);
                string filepath = directoryPath + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(filename);
                // Ограничение длины пути к файлу.
                if ((filepath.Length > 230) && (filename.Length > filepath.Length - filepath.Substring(0, 229).Length))
                    filepath = filepath.Substring(0, 229);

                SaveFile(filepath + "_" + dateFormat + Path.GetExtension(filename), currentTabControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        /// <summary>
        /// Закрытие текущей вкладки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (!TabsManager.TabsAreOpen(tabControl)) return;
            // Удаление текущей вкладки с панели вкладок.
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        /// <summary>
        /// Выход из приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверка подтверждения выхода.
            if (MessageBox.Show("Выйти из приложения?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            // Сохранение путей незакрытых файлов.
            if (tabControl.TabPages != null)
            {
                Properties.Settings.Default.openedFiles = new string[tabControl.TabPages.Count];
                for (int i = 0; i < tabControl.TabPages.Count; i++)
                {
                    Properties.Settings.Default.openedFiles[i] = tabControl.TabPages[i].Name;
                }
            }
            else Properties.Settings.Default.openedFiles = new string[0];

            Properties.Settings.Default.timeInterval = timer.Interval;
            // Сохранение настроек.
            Properties.Settings.Default.Save();

            DialogResult dialogResult = MessageBox.Show("Сохранить несохраненные файлы?", "", MessageBoxButtons.YesNo);
            // Сохранение несохраненных файлов.
            if (dialogResult == DialogResult.Yes)
            {
                foreach (TabPage page in tabControl.TabPages)
                {
                    tabControl.SelectedTab = page;
                    SaveToolStripMenuItem_Click(null, null);
                }
            }
        }
    }
}