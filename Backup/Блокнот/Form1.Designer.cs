namespace Notepad
{
    partial class NotepadForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.parameters = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.put = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.findNext = new System.Windows.Forms.ToolStripMenuItem();
            this.replase = new System.Windows.Forms.ToolStripMenuItem();
            this.goTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.date = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWarp = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.look = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.openReadme = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Str = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Stl = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.format,
            this.look,
            this.help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.open,
            this.save,
            this.saveAs,
            this.toolStripSeparator1,
            this.parameters,
            this.print,
            this.toolStripSeparator2,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(48, 20);
            this.file.Text = "Файл";
            // 
            // create
            // 
            this.create.Name = "create";
            this.create.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.create.Size = new System.Drawing.Size(204, 22);
            this.create.Text = "Создать";
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open.Size = new System.Drawing.Size(204, 22);
            this.open.Text = "Открыть...";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(204, 22);
            this.save.Text = "Сохранить";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(204, 22);
            this.saveAs.Text = "Сохранить как...";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // parameters
            // 
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(204, 22);
            this.parameters.Text = "Параметры страницы...";
            this.parameters.Click += new System.EventHandler(this.parameters_Click);
            // 
            // print
            // 
            this.print.Name = "print";
            this.print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.print.Size = new System.Drawing.Size(204, 22);
            this.print.Text = "Печать...";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(204, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo,
            this.toolStripSeparator3,
            this.cut,
            this.copy,
            this.put,
            this.delete,
            this.toolStripSeparator4,
            this.find,
            this.findNext,
            this.replase,
            this.goTo,
            this.toolStripSeparator5,
            this.selectAll,
            this.date});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(59, 20);
            this.edit.Text = "Правка";
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo.Size = new System.Drawing.Size(190, 22);
            this.undo.Text = "Отменить";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut.Size = new System.Drawing.Size(190, 22);
            this.cut.Text = "Вырезать";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy.Size = new System.Drawing.Size(190, 22);
            this.copy.Text = "Копировать";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // put
            // 
            this.put.Name = "put";
            this.put.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.put.Size = new System.Drawing.Size(190, 22);
            this.put.Text = "Вставить";
            this.put.Click += new System.EventHandler(this.put_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delete.Size = new System.Drawing.Size(190, 22);
            this.delete.Text = "Удалить";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.find.Size = new System.Drawing.Size(190, 22);
            this.find.Text = "Найти...";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // findNext
            // 
            this.findNext.Name = "findNext";
            this.findNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findNext.Size = new System.Drawing.Size(190, 22);
            this.findNext.Text = "Найти далее";
            this.findNext.Click += new System.EventHandler(this.findNext_Click);
            // 
            // replase
            // 
            this.replase.Name = "replase";
            this.replase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replase.Size = new System.Drawing.Size(190, 22);
            this.replase.Text = "Заменить...";
            this.replase.Click += new System.EventHandler(this.replase_Click);
            // 
            // goTo
            // 
            this.goTo.Name = "goTo";
            this.goTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goTo.Size = new System.Drawing.Size(190, 22);
            this.goTo.Text = "Перейти...";
            this.goTo.Click += new System.EventHandler(this.goTo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // selectAll
            // 
            this.selectAll.Name = "selectAll";
            this.selectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAll.Size = new System.Drawing.Size(190, 22);
            this.selectAll.Text = "Выделить все";
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // date
            // 
            this.date.Name = "date";
            this.date.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.date.Size = new System.Drawing.Size(190, 22);
            this.date.Text = "Время и дата";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // format
            // 
            this.format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWarp,
            this.font});
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(62, 20);
            this.format.Text = "Формат";
            // 
            // wordWarp
            // 
            this.wordWarp.Name = "wordWarp";
            this.wordWarp.Size = new System.Drawing.Size(183, 22);
            this.wordWarp.Text = "Перенос по словам";
            this.wordWarp.Click += new System.EventHandler(this.wordWarp_Click);
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(183, 22);
            this.font.Text = "Шрифт...";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // look
            // 
            this.look.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(39, 20);
            this.look.Text = "Вид";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(173, 22);
            this.status.Text = "Строка состояния";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReadme,
            this.toolStripSeparator6,
            this.about});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(65, 20);
            this.help.Text = "Справка";
            // 
            // openReadme
            // 
            this.openReadme.Name = "openReadme";
            this.openReadme.Size = new System.Drawing.Size(188, 22);
            this.openReadme.Text = "Посмотреть справку";
            this.openReadme.Click += new System.EventHandler(this.openReadme_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(185, 6);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(188, 22);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.AllowDrop = true;
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.mainTextBox.Location = new System.Drawing.Point(0, 28);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(484, 412);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.WordWrap = false;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            this.mainTextBox.Click += new System.EventHandler(this.mainTextBox_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Str,
            this.toolStripStatusLabel3,
            this.Stl});
            this.statusStrip.Location = new System.Drawing.Point(0, 440);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel1.Text = "Cтр:";
            // 
            // Str
            // 
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(13, 17);
            this.Str.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel3.Text = ",Стл:";
            // 
            // Stl
            // 
            this.Stl.Name = "Stl";
            this.Stl.Size = new System.Drawing.Size(13, 17);
            this.Stl.Text = "0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.OriginAtMargins = true;
            // 
            // fontDialog
            // 
            this.fontDialog.FixedPitchOnly = true;
            this.fontDialog.FontMustExist = true;
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "NotepadForm";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem format;
        private System.Windows.Forms.ToolStripMenuItem look;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem parameters;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem put;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.ToolStripMenuItem findNext;
        private System.Windows.Forms.ToolStripMenuItem replase;
        private System.Windows.Forms.ToolStripMenuItem goTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
        private System.Windows.Forms.ToolStripMenuItem date;
        private System.Windows.Forms.ToolStripMenuItem wordWarp;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem status;
        private System.Windows.Forms.ToolStripMenuItem openReadme;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Str;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel Stl;
        internal System.Windows.Forms.TextBox mainTextBox;
    }
}

