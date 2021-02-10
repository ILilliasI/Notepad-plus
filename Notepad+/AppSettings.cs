using ScintillaNET;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad_
{
    class AppSettings
    {
        // Цвет фона.
        public static Color backColor
        {
            get
            {
                return Properties.Settings.Default.backgroundColor;
            }
            set
            {
                Properties.Settings.Default.backgroundColor = value;
            }
        }

        // Цвет шрифта.
        public static Color fontColor
        {
            get
            {
                return Properties.Settings.Default.fontColor;
            }
            set
            {
                Properties.Settings.Default.fontColor = value;
            }
        }

        /// <summary>
        /// Изменение шрифта в коде.
        /// </summary>
        /// <param name="textArea"></param>
        /// <param name="font"></param>
        /// <param name="size"></param>
        public static void ChangeCodeFont(Scintilla textArea, string font, int size)
        {
            textArea.Styles[Style.Default].Size = size;
            textArea.Styles[Style.Default].Font = font;
            textArea.StyleClearAll();
        }

        /// <summary>
        /// Метод, устанавливающий цветовую тему вкладки с открытым .cs файлом.
        /// </summary>
        /// <param name="textArea"></param>
        public static void ColorizeCodeTab(Scintilla textArea)
        {
            textArea.Styles[Style.Default].BackColor = backColor;
            textArea.Styles[Style.Default].ForeColor = fontColor;
            textArea.Styles[Style.Cpp.Identifier].ForeColor = fontColor;
            textArea.StyleClearAll();
        }

        /// <summary>
        /// Подсветка синтаксиса кода C#.
        /// </summary>
        /// <param name="textArea"></param>
        public static void InitSyntaxColoring(Scintilla textArea)
        {
            textArea.Styles[Style.Cpp.Comment].ForeColor = Properties.Settings.Default.commentsColor;
            textArea.Styles[Style.Cpp.CommentLine].ForeColor = Properties.Settings.Default.commentsColor;
            textArea.Styles[Style.Cpp.CommentDoc].ForeColor = Properties.Settings.Default.commentDocColor;
            textArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = Properties.Settings.Default.commentDocColor;
            textArea.Styles[Style.Cpp.String].ForeColor = Properties.Settings.Default.stringColor;
            textArea.Styles[Style.Cpp.Operator].ForeColor = Properties.Settings.Default.operatorsColor;
            textArea.Styles[Style.Cpp.Word2].ForeColor = Properties.Settings.Default.keyWordsColor;
            textArea.Lexer = Lexer.Cpp;

            textArea.SetKeywords(1, @"abstract as base bool break byte case catch char checked class const continue
                                    decimal default delegate do double else enum event explicit extern false finally
                                    fixed float for foreach goto if implicit in int interface internal is lock long 
                                    namespace new null object operator out override params private protected public 
                                    readonly ref return sbyte sealed short sizeof stackalloc static string struct 
                                    switch this throw true try typeof unit ulong unchecked unsafe ushort using virtual 
                                    void volatile while");
        }

        /// <summary>
        /// Метод, изменяющий цвет фона приложения.
        /// </summary>
        /// <param name="tabcontrol"></param>
        /// <param name="upperMenu"></param>
        /// <param name="lowerPanel"></param>
        /// <param name="panel"></param>
        public static void ChangeBackColor(TabControl tabcontrol, MenuStrip upperMenu, Panel lowerPanel, Panel panel)
        {
            backColor = Properties.Settings.Default.backgroundColor;

            foreach (Control page in tabcontrol.TabPages)
            {
                foreach (Control textBox in page.Controls)
                {
                    textBox.BackColor = backColor;
                    // Установка цвета фона для кода.
                    if (textBox.HasChildren)
                    {
                        Scintilla textArea = (Scintilla)textBox.Controls[0];
                        ColorizeCodeTab(textArea);
                        InitSyntaxColoring(textArea);
                    }
                }
            }
            upperMenu.BackColor = backColor;
            lowerPanel.BackColor = backColor;
            panel.BackColor = backColor;
        }

        /// <summary>
        /// Метод, изменяющий цвет шрифта приложения.
        /// </summary>
        /// <param name="tabcontrol"></param>
        /// <param name="upperMenu"></param>
        /// <param name="closeButton"></param>
        public static void ChangeFontColor(TabControl tabcontrol, MenuStrip upperMenu, Button closeButton)
        {
            fontColor = Properties.Settings.Default.fontColor;

            foreach (Control page in tabcontrol.TabPages)
            {
                foreach (Control textBox in page.Controls)
                {
                    textBox.ForeColor = fontColor;
                    // Установка цвета шрифта для кода.
                    if (textBox.HasChildren)
                    {
                        Scintilla textArea = (Scintilla)textBox.Controls[0];
                        ColorizeCodeTab(textArea);
                        InitSyntaxColoring(textArea);
                    }
                }
            }
            upperMenu.ForeColor = fontColor;
            closeButton.ForeColor = fontColor;
        }

        /// <summary>
        /// Метод, удаляющий необходимый стиль текста.
        /// </summary>
        /// <param name="currentFontStyle"> Текущий стиль. </param>
        /// <param name="styleToDelete"> Стиль для удаления. </param>
        /// <returns> Новый стиль. </returns>
        public static FontStyle DeleteFontStyle(FontStyle currentFontStyle, string styleToDelete)
        {
            // Создание нового стиля.
            FontStyle newFontStyle = new FontStyle();

            if ((styleToDelete != "bold") && ((currentFontStyle & FontStyle.Bold) == FontStyle.Bold))
            {
                newFontStyle |= FontStyle.Bold;
            }

            if ((styleToDelete != "italic") && ((currentFontStyle & FontStyle.Italic) == FontStyle.Italic))
            {
                newFontStyle |= FontStyle.Italic;
            }

            if ((styleToDelete != "underline") && ((currentFontStyle & FontStyle.Underline) == FontStyle.Underline))
            {
                newFontStyle |= FontStyle.Underline;
            }

            if ((styleToDelete != "strikeout") && ((currentFontStyle & FontStyle.Strikeout) == FontStyle.Strikeout))
            {
                newFontStyle |= FontStyle.Strikeout;
            }
            return newFontStyle;
        }
    }
}
