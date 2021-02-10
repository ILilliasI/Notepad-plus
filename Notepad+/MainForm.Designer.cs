
namespace Notepad_
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.formatContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeoutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForPanels = new System.Windows.Forms.Panel();
            this.upperMenuPanel = new System.Windows.Forms.Panel();
            this.upperMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.formatCodeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syntaxHighlightingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docCommentsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyWordsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.autoSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOnSavingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOffSavingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOnLoggingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOffLoggingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.intervalStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every15secondsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.everyMinuteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every5MinutesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every30MinutesStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.everyHourStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerMenuPanel = new System.Windows.Forms.Panel();
            this.underlineButton = new System.Windows.Forms.Button();
            this.strikeoutButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.backColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.codeColorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip.SuspendLayout();
            this.panelForPanels.SuspendLayout();
            this.upperMenuPanel.SuspendLayout();
            this.upperMenuStrip.SuspendLayout();
            this.lowerMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 85);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(7, 7);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 365);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllContextMenuItem,
            this.toolStripSeparator6,
            this.cutContextMenuItem,
            this.copyContextMenuItem,
            this.pasteContextMenuItem,
            this.toolStripSeparator7,
            this.formatContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(232, 176);
            // 
            // selectAllContextMenuItem
            // 
            this.selectAllContextMenuItem.Name = "selectAllContextMenuItem";
            this.selectAllContextMenuItem.Size = new System.Drawing.Size(231, 32);
            this.selectAllContextMenuItem.Text = "Выбрать все";
            this.selectAllContextMenuItem.Click += new System.EventHandler(this.SelectAllContextMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(228, 6);
            // 
            // cutContextMenuItem
            // 
            this.cutContextMenuItem.Name = "cutContextMenuItem";
            this.cutContextMenuItem.Size = new System.Drawing.Size(231, 32);
            this.cutContextMenuItem.Text = "Вырезать";
            this.cutContextMenuItem.Click += new System.EventHandler(this.CutContextMenuItem_Click);
            // 
            // copyContextMenuItem
            // 
            this.copyContextMenuItem.Name = "copyContextMenuItem";
            this.copyContextMenuItem.Size = new System.Drawing.Size(231, 32);
            this.copyContextMenuItem.Text = "Копировать";
            this.copyContextMenuItem.Click += new System.EventHandler(this.CopyContextMenuItem_Click);
            // 
            // pasteContextMenuItem
            // 
            this.pasteContextMenuItem.Name = "pasteContextMenuItem";
            this.pasteContextMenuItem.Size = new System.Drawing.Size(231, 32);
            this.pasteContextMenuItem.Text = "Вставить";
            this.pasteContextMenuItem.Click += new System.EventHandler(this.PasteContextMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(228, 6);
            // 
            // formatContextMenuItem
            // 
            this.formatContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldContextMenuItem,
            this.italicContextMenuItem,
            this.underlineContextMenuItem,
            this.strikeoutContextMenuItem});
            this.formatContextMenuItem.Name = "formatContextMenuItem";
            this.formatContextMenuItem.Size = new System.Drawing.Size(231, 32);
            this.formatContextMenuItem.Text = "Изменить формат";
            // 
            // boldContextMenuItem
            // 
            this.boldContextMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boldContextMenuItem.Name = "boldContextMenuItem";
            this.boldContextMenuItem.Size = new System.Drawing.Size(236, 34);
            this.boldContextMenuItem.Text = "Жирный";
            this.boldContextMenuItem.Click += new System.EventHandler(this.BoldContextMenuItem_Click);
            // 
            // italicContextMenuItem
            // 
            this.italicContextMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italicContextMenuItem.Name = "italicContextMenuItem";
            this.italicContextMenuItem.Size = new System.Drawing.Size(236, 34);
            this.italicContextMenuItem.Text = "Курсив";
            this.italicContextMenuItem.Click += new System.EventHandler(this.ItalicContextMenuItem_Click);
            // 
            // underlineContextMenuItem
            // 
            this.underlineContextMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underlineContextMenuItem.Name = "underlineContextMenuItem";
            this.underlineContextMenuItem.Size = new System.Drawing.Size(236, 34);
            this.underlineContextMenuItem.Text = "Подчеркнутый";
            this.underlineContextMenuItem.Click += new System.EventHandler(this.UnderlineContextMenuItem_Click);
            // 
            // strikeoutContextMenuItem
            // 
            this.strikeoutContextMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.strikeoutContextMenuItem.Name = "strikeoutContextMenuItem";
            this.strikeoutContextMenuItem.Size = new System.Drawing.Size(236, 34);
            this.strikeoutContextMenuItem.Text = "Зачеркнутый";
            this.strikeoutContextMenuItem.Click += new System.EventHandler(this.StrikeoutContextMenuItem_Click);
            // 
            // panelForPanels
            // 
            this.panelForPanels.Controls.Add(this.upperMenuPanel);
            this.panelForPanels.Controls.Add(this.lowerMenuPanel);
            this.panelForPanels.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForPanels.Location = new System.Drawing.Point(0, 0);
            this.panelForPanels.Name = "panelForPanels";
            this.panelForPanels.Size = new System.Drawing.Size(800, 85);
            this.panelForPanels.TabIndex = 2;
            // 
            // upperMenuPanel
            // 
            this.upperMenuPanel.Controls.Add(this.upperMenuStrip);
            this.upperMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.upperMenuPanel.Name = "upperMenuPanel";
            this.upperMenuPanel.Size = new System.Drawing.Size(800, 40);
            this.upperMenuPanel.TabIndex = 0;
            // 
            // upperMenuStrip
            // 
            this.upperMenuStrip.AutoSize = false;
            this.upperMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upperMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.upperMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.upperMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.upperMenuStrip.Name = "upperMenuStrip";
            this.upperMenuStrip.Size = new System.Drawing.Size(800, 40);
            this.upperMenuStrip.TabIndex = 2;
            this.upperMenuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(378, 36);
            this.newToolStripMenuItem.Text = "Создать";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(378, 36);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(375, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(378, 36);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(378, 36);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(375, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(378, 36);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.undoToolStripMenuItem.Text = "Отменить";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.redoToolStripMenuItem.Text = "Повторить";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(342, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(342, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(345, 36);
            this.selectAllToolStripMenuItem.Text = "Выбрать все";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.formatCodeStripMenuItem,
            this.syntaxHighlightingStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.formatToolStripMenuItem.Text = "Формат";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(416, 36);
            this.customizeToolStripMenuItem.Text = "Параметры шрифта";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.CustomizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(413, 6);
            // 
            // formatCodeStripMenuItem
            // 
            this.formatCodeStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("formatCodeStripMenuItem.Image")));
            this.formatCodeStripMenuItem.Name = "formatCodeStripMenuItem";
            this.formatCodeStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.formatCodeStripMenuItem.Size = new System.Drawing.Size(416, 36);
            this.formatCodeStripMenuItem.Text = "Отформатировать C# код";
            this.formatCodeStripMenuItem.Click += new System.EventHandler(this.FormatCodeStripMenuItem_Click);
            // 
            // syntaxHighlightingStripMenuItem
            // 
            this.syntaxHighlightingStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentsStripMenuItem,
            this.docCommentsStripMenuItem,
            this.keyWordsStripMenuItem,
            this.stringsStripMenuItem,
            this.operatorsStripMenuItem});
            this.syntaxHighlightingStripMenuItem.Name = "syntaxHighlightingStripMenuItem";
            this.syntaxHighlightingStripMenuItem.ShowShortcutKeys = false;
            this.syntaxHighlightingStripMenuItem.Size = new System.Drawing.Size(416, 36);
            this.syntaxHighlightingStripMenuItem.Text = "Подсветка синтаксиса";
            this.syntaxHighlightingStripMenuItem.ToolTipText = "Только для .cs файлов";
            // 
            // commentsStripMenuItem
            // 
            this.commentsStripMenuItem.Name = "commentsStripMenuItem";
            this.commentsStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.commentsStripMenuItem.Text = "Комментарии";
            this.commentsStripMenuItem.Click += new System.EventHandler(this.CommentsStripMenuItem_Click);
            // 
            // docCommentsStripMenuItem
            // 
            this.docCommentsStripMenuItem.Name = "docCommentsStripMenuItem";
            this.docCommentsStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.docCommentsStripMenuItem.Text = "XML-комментарии";
            this.docCommentsStripMenuItem.Click += new System.EventHandler(this.DocCommentsStripMenuItem_Click);
            // 
            // keyWordsStripMenuItem
            // 
            this.keyWordsStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.keyWordsStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.keyWordsStripMenuItem.Name = "keyWordsStripMenuItem";
            this.keyWordsStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.keyWordsStripMenuItem.Text = "Ключевые слова";
            this.keyWordsStripMenuItem.Click += new System.EventHandler(this.KeyWordsStripMenuItem_Click);
            // 
            // stringsStripMenuItem
            // 
            this.stringsStripMenuItem.Name = "stringsStripMenuItem";
            this.stringsStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.stringsStripMenuItem.Text = "Строки";
            this.stringsStripMenuItem.Click += new System.EventHandler(this.StringsStripMenuItem_Click);
            // 
            // operatorsStripMenuItem
            // 
            this.operatorsStripMenuItem.Name = "operatorsStripMenuItem";
            this.operatorsStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.operatorsStripMenuItem.Text = "Операторы";
            this.operatorsStripMenuItem.Click += new System.EventHandler(this.OperatorsStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorStripMenuItem,
            this.fontColorMenuItem,
            this.toolStripSeparator5,
            this.autoSaveToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // backColorStripMenuItem
            // 
            this.backColorStripMenuItem.Name = "backColorStripMenuItem";
            this.backColorStripMenuItem.Size = new System.Drawing.Size(449, 36);
            this.backColorStripMenuItem.Text = "Цвет фона";
            this.backColorStripMenuItem.Click += new System.EventHandler(this.BackColorStripMenuItem_Click);
            // 
            // fontColorMenuItem
            // 
            this.fontColorMenuItem.Name = "fontColorMenuItem";
            this.fontColorMenuItem.Size = new System.Drawing.Size(449, 36);
            this.fontColorMenuItem.Text = "Цвет текста";
            this.fontColorMenuItem.Click += new System.EventHandler(this.FontColorMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(446, 6);
            // 
            // autoSaveToolStripMenuItem
            // 
            this.autoSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnOnSavingMenuItem,
            this.turnOffSavingMenuItem,
            this.turnOnLoggingMenuItem,
            this.turnOffLoggingMenuItem,
            this.toolStripSeparator8,
            this.intervalStripMenuItem,
            this.every15secondsStripMenuItem,
            this.everyMinuteStripMenuItem,
            this.every5MinutesMenuItem,
            this.every30MinutesStripMenuItem,
            this.everyHourStripMenuItem});
            this.autoSaveToolStripMenuItem.Name = "autoSaveToolStripMenuItem";
            this.autoSaveToolStripMenuItem.Size = new System.Drawing.Size(449, 36);
            this.autoSaveToolStripMenuItem.Text = "Автосохранение и журналирование";
            this.autoSaveToolStripMenuItem.ToolTipText = "Сохраняется только текущий файл";
            // 
            // turnOnSavingMenuItem
            // 
            this.turnOnSavingMenuItem.Name = "turnOnSavingMenuItem";
            this.turnOnSavingMenuItem.Size = new System.Drawing.Size(532, 36);
            this.turnOnSavingMenuItem.Text = "Включить автосохранение текущего файла";
            this.turnOnSavingMenuItem.ToolTipText = "Срабатывает одновременно с журналированием (если оно включено)";
            this.turnOnSavingMenuItem.Click += new System.EventHandler(this.TurnOnSavingMenuItem_Click);
            // 
            // turnOffSavingMenuItem
            // 
            this.turnOffSavingMenuItem.Name = "turnOffSavingMenuItem";
            this.turnOffSavingMenuItem.Size = new System.Drawing.Size(532, 36);
            this.turnOffSavingMenuItem.Text = "Выключить автосохранение";
            this.turnOffSavingMenuItem.Click += new System.EventHandler(this.TurnOffSavingMenuItem_Click);
            // 
            // turnOnLoggingMenuItem
            // 
            this.turnOnLoggingMenuItem.Name = "turnOnLoggingMenuItem";
            this.turnOnLoggingMenuItem.Size = new System.Drawing.Size(532, 36);
            this.turnOnLoggingMenuItem.Text = "Включить журналирование текущего файла";
            this.turnOnLoggingMenuItem.ToolTipText = "Срабатывает одновременно с автосохранением (если оно включено)";
            this.turnOnLoggingMenuItem.Click += new System.EventHandler(this.TurnOnLoggingMenuItem_Click);
            // 
            // turnOffLoggingMenuItem
            // 
            this.turnOffLoggingMenuItem.Name = "turnOffLoggingMenuItem";
            this.turnOffLoggingMenuItem.Size = new System.Drawing.Size(532, 36);
            this.turnOffLoggingMenuItem.Text = "Выключить журналирование";
            this.turnOffLoggingMenuItem.Click += new System.EventHandler(this.TurnOffLoggingMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(529, 6);
            // 
            // intervalStripMenuItem
            // 
            this.intervalStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.intervalStripMenuItem.Enabled = false;
            this.intervalStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.intervalStripMenuItem.Name = "intervalStripMenuItem";
            this.intervalStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.intervalStripMenuItem.Text = "Выберите интервал (1 мин. по умолчанию):";
            // 
            // every15secondsStripMenuItem
            // 
            this.every15secondsStripMenuItem.Name = "every15secondsStripMenuItem";
            this.every15secondsStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.every15secondsStripMenuItem.Text = "Каждые 15 секунд";
            this.every15secondsStripMenuItem.Click += new System.EventHandler(this.Every15secondsStripMenuItem_Click);
            // 
            // everyMinuteStripMenuItem
            // 
            this.everyMinuteStripMenuItem.Name = "everyMinuteStripMenuItem";
            this.everyMinuteStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.everyMinuteStripMenuItem.Text = "Каждую минуту";
            this.everyMinuteStripMenuItem.Click += new System.EventHandler(this.EveryMinuteStripMenuItem_Click);
            // 
            // every5MinutesMenuItem
            // 
            this.every5MinutesMenuItem.Name = "every5MinutesMenuItem";
            this.every5MinutesMenuItem.Size = new System.Drawing.Size(532, 36);
            this.every5MinutesMenuItem.Text = "Каждые 5 минут";
            this.every5MinutesMenuItem.Click += new System.EventHandler(this.Every5MinutesMenuItem_Click);
            // 
            // every30MinutesStripMenuItem
            // 
            this.every30MinutesStripMenuItem.Name = "every30MinutesStripMenuItem";
            this.every30MinutesStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.every30MinutesStripMenuItem.Text = "Каждые 30 минут";
            this.every30MinutesStripMenuItem.Click += new System.EventHandler(this.Every30MinutesStripMenuItem_Click);
            // 
            // everyHourStripMenuItem
            // 
            this.everyHourStripMenuItem.Name = "everyHourStripMenuItem";
            this.everyHourStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.everyHourStripMenuItem.Text = "Каждый час";
            this.everyHourStripMenuItem.Click += new System.EventHandler(this.EveryHourStripMenuItem_Click);
            // 
            // lowerMenuPanel
            // 
            this.lowerMenuPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lowerMenuPanel.Controls.Add(this.underlineButton);
            this.lowerMenuPanel.Controls.Add(this.strikeoutButton);
            this.lowerMenuPanel.Controls.Add(this.italicButton);
            this.lowerMenuPanel.Controls.Add(this.boldButton);
            this.lowerMenuPanel.Controls.Add(this.closeButton);
            this.lowerMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerMenuPanel.Location = new System.Drawing.Point(0, 43);
            this.lowerMenuPanel.Name = "lowerMenuPanel";
            this.lowerMenuPanel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lowerMenuPanel.Size = new System.Drawing.Size(800, 42);
            this.lowerMenuPanel.TabIndex = 1;
            // 
            // underlineButton
            // 
            this.underlineButton.BackColor = System.Drawing.SystemColors.Control;
            this.underlineButton.FlatAppearance.BorderSize = 0;
            this.underlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlineButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underlineButton.Location = new System.Drawing.Point(113, 4);
            this.underlineButton.Name = "underlineButton";
            this.underlineButton.Size = new System.Drawing.Size(35, 35);
            this.underlineButton.TabIndex = 7;
            this.underlineButton.Text = "Ч";
            this.underlineButton.UseVisualStyleBackColor = false;
            this.underlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // strikeoutButton
            // 
            this.strikeoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.strikeoutButton.FlatAppearance.BorderSize = 0;
            this.strikeoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strikeoutButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.strikeoutButton.Location = new System.Drawing.Point(163, 4);
            this.strikeoutButton.Name = "strikeoutButton";
            this.strikeoutButton.Size = new System.Drawing.Size(35, 35);
            this.strikeoutButton.TabIndex = 6;
            this.strikeoutButton.Text = "З";
            this.strikeoutButton.UseVisualStyleBackColor = false;
            this.strikeoutButton.Click += new System.EventHandler(this.StrikeoutButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.BackColor = System.Drawing.SystemColors.Control;
            this.italicButton.FlatAppearance.BorderSize = 0;
            this.italicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italicButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italicButton.Location = new System.Drawing.Point(62, 4);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(35, 35);
            this.italicButton.TabIndex = 5;
            this.italicButton.Text = "К";
            this.italicButton.UseVisualStyleBackColor = false;
            this.italicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // boldButton
            // 
            this.boldButton.BackColor = System.Drawing.SystemColors.Control;
            this.boldButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.boldButton.FlatAppearance.BorderSize = 0;
            this.boldButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.boldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldButton.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boldButton.Location = new System.Drawing.Point(12, 3);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(35, 35);
            this.boldButton.TabIndex = 3;
            this.boldButton.Text = "Ж";
            this.boldButton.UseVisualStyleBackColor = false;
            this.boldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(571, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(199, 42);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Закрыть вкладку";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // backColorDialog
            // 
            this.backColorDialog.FullOpen = true;
            // 
            // fontColorDialog
            // 
            this.fontColorDialog.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelForPanels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Notepad+";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.panelForPanels.ResumeLayout(false);
            this.upperMenuPanel.ResumeLayout(false);
            this.upperMenuStrip.ResumeLayout(false);
            this.upperMenuStrip.PerformLayout();
            this.lowerMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelForPanels;
        private System.Windows.Forms.Panel upperMenuPanel;
        private System.Windows.Forms.MenuStrip upperMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem autoSaveToolStripMenuItem;
        private System.Windows.Forms.Panel lowerMenuPanel;
        private System.Windows.Forms.Button underlineButton;
        private System.Windows.Forms.Button strikeoutButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fontColorMenuItem;
        private System.Windows.Forms.ColorDialog backColorDialog;
        private System.Windows.Forms.ColorDialog fontColorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem formatCodeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem formatContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikeoutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem everyMinuteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every5MinutesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every30MinutesStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem everyHourStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every15secondsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOnSavingMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem syntaxHighlightingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docCommentsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyWordsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringsStripMenuItem;
        private System.Windows.Forms.ColorDialog codeColorDialog;
        private System.Windows.Forms.ToolStripMenuItem turnOnLoggingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOffLoggingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnOffSavingMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem intervalStripMenuItem;
    }
}

