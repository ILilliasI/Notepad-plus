using ScintillaNET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Notepad_
{
    class TabsManager
    {

        /// <summary>
        /// Метод, создающий новую вкладку.
        /// </summary>
        /// <param name="filepath"> Путь к файлу, который надо открыть во вкладке. </param>
        /// <param name="toOpen"> Надо ли открыть файл. </param>
        /// <returns> Новая вкладка. </returns>
        public static TabPage CreateTabPage(string filepath, bool toOpen = false)
        {
            string fileName = Path.GetFileName(filepath);

            // Создание новой вкладки.
            TabPage newPage = new TabPage
            {
                Name = filepath,
                Text = fileName,
                BackColor = AppSettings.backColor,
            };
            var newTextBox = new RichTextBox
            {
                Name = filepath,
                Dock = DockStyle.Fill,
                ForeColor = AppSettings.fontColor,
                BackColor = AppSettings.backColor,
                // AcceptsTab = true,
            };

            // Дополнительные параметры для .cs файла.
            if (Path.GetExtension(filepath) == ".cs")
            {
                Scintilla textArea = new Scintilla { Dock = DockStyle.Fill, Text = "" };
                newTextBox.Controls.Add(textArea);

                AppSettings.ColorizeCodeTab(textArea);
                AppSettings.InitSyntaxColoring(textArea);
            }

            // Получение текста из файла в зависимости от расширения.
            if (toOpen)
            {
                LoadTextFromFile(filepath, newTextBox);
            }
            newPage.Controls.Add(newTextBox);
            return newPage;
        }

        /// <summary>
        /// Метод, получающий текст из файла и отображающий его на текущей вкладке.
        /// </summary>
        /// <param name="filepath"> Путь к файлу с текстом. </param>
        /// <param name="newTextBox"></param>
        public static void LoadTextFromFile(string filepath, RichTextBox newTextBox)
        {
            if (Path.GetExtension(filepath) == ".rtf")
            {
                newTextBox.LoadFile(filepath, RichTextBoxStreamType.RichText);
            }
            else if (Path.GetExtension(filepath) == ".cs")
            {
                newTextBox.Controls[0].Text = File.ReadAllText(filepath);
                Scintilla textArea = (Scintilla)newTextBox.Controls[0];
                // Раскрашивание кода.
                AppSettings.ColorizeCodeTab(textArea);
                AppSettings.InitSyntaxColoring(textArea);
            }
            else
                newTextBox.LoadFile(filepath, RichTextBoxStreamType.PlainText);
        }

        /// <summary>
        /// Метод, открывающий незакрытые файлы.
        /// </summary>
        /// <param name="tabControl"></param>
        public static void OpenUnclosedFiles(TabControl tabControl)
        {
            try
            {
                foreach (string filepath in Properties.Settings.Default.openedFiles)
                {
                    if (File.Exists(filepath))
                    {
                        TabPage newPage = CreateTabPage(filepath, true);

                        // Добавление вкладки на форму.
                        tabControl.Controls.Add(newPage);
                        tabControl.SelectedTab = tabControl.TabPages[newPage.Name];
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Метод, проверяющий наличие открытых вкладок.
        /// </summary>
        /// <param name="tabControl"> Панель вкладок. </param>
        /// <returns> Открыты ли вкладки. </returns>
        public static bool TabsAreOpen(TabControl tabControl)
        {
            if (!tabControl.HasChildren)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Метод, который проверяет, открыт ли данный файл в программе.
        /// </summary>
        /// <param name="filename"> Имя файла. </param>
        /// <param name="tabСontrol"> Панель вкладок. </param>
        /// <returns></returns>
        public static bool IsThisPageOpen(string filename, TabControl tabСontrol)
        {
            foreach (Control page in tabСontrol.TabPages)
            {
                if (page.Name == filename)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
