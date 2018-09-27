using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class NotepadForm : Form
    {

        private SearchArgs sa;
        private SearchForm sf;
        private ReplaseForm rf;

        public NotepadForm(string path = "")
        {
            InitializeComponent();
            sa = new SearchArgs();
            mainTextBox.DragEnter += NotepadForm_DragEnter;
            mainTextBox.DragDrop += NotepadForm_DragDrop;
            FileName = path;
            if (!string.IsNullOrEmpty(path))
            {
                if (Path.GetExtension(path) == ".rtf")
                {
                    mainTextBox.LoadFile(path, RichTextBoxStreamType.RichText);
                }
                else
                {
                    mainTextBox.LoadFile(path, RichTextBoxStreamType.PlainText);
                }
            }
        }

        public bool IsDocumentEmpty { get { return mainTextBox.Text.Length == 0; } }
        public bool IsSelected { get { return mainTextBox.SelectionLength != 0; } }
        public bool WordWrap { set { mainTextBox.WordWrap = value; } }
        public bool IsBold { get { return mainTextBox.SelectionFont?.Bold ?? false; }}
        public bool IsItalic { get { return mainTextBox.SelectionFont?.Italic ?? false; } }
        public bool IsStrikeout { get { return mainTextBox.SelectionFont?.Strikeout ?? false; } }
        public bool IsUnderline { get { return mainTextBox.SelectionFont?.Underline ?? false; } }
        public bool IsBullet { get { return mainTextBox.SelectionBullet; } }
        public HorizontalAlignment Alignment {get{ return mainTextBox.SelectionAlignment;}}
        public bool CanUndo { get { return mainTextBox.CanUndo; } }
        public bool CanRedo { get { return mainTextBox.CanRedo; } }
        public Color Fore { get { return mainTextBox.SelectionColor; } }
        public Color Back { get { return mainTextBox.SelectionBackColor; } }
        
        public string FileName { get; private set; }

        public event EventHandler DocumentChanged
        {
            add
            {
                mainTextBox.TextChanged += value;
                mainTextBox.SelectionChanged += value;
            }
            remove
            {
                mainTextBox.TextChanged -= value;
                mainTextBox.SelectionChanged -= value;
            }
        }

        public void Save()
        {
            if (FileName == string.Empty)
            {
                SaveAs();
            }else
            {
                InternalSave();
            }
        }

        public void SaveAs()
        {
            var sfd = new SaveFileDialog() { Filter = "Text Document(*.txt)|*.txt|Rich Text Format Document(*.rtf)|*.rtf|All Files(*.*)|*.*" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileName = sfd.FileName;
                InternalSave();
            }
        }

        public void ShowPageSetup()
        {
            new PageSetupDialog() { PageSettings=new System.Drawing.Printing.PageSettings()}.ShowDialog();
        }

        public void ShowPrint()
        {
            printDialog.ShowDialog();
        }

        public void Undo()
        {
            mainTextBox.Undo();
        }

        public void Redo()
        {
            mainTextBox.Redo();
        }

        public void Cut()
        {
            mainTextBox.Cut();
        }

        public void Copy()
        {
            mainTextBox.Copy();
        }

        public void Paste()
        {
            if (Clipboard.GetFileDropList().Count>0)
            {
                Image image = Image.FromFile(Clipboard.GetFileDropList()[0]);
                Clipboard.Clear();
                Clipboard.SetImage(image);
                if (Clipboard.ContainsImage() && mainTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                {
                    mainTextBox.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
                    Clipboard.Clear();
                }
                else
                {
                    mainTextBox.Paste();
                }
            }
            else
            {
                mainTextBox.Paste();
            }
        }

        public void Delelte()
        {
            if (mainTextBox.SelectionLength == 0)
            {
                mainTextBox.SelectionLength = 1;
            }
            mainTextBox.SelectedText = string.Empty;
        }

        public void SelectAll()
        {
            mainTextBox.SelectAll();
        }

        public void DateAndTime()
        {
            mainTextBox.SelectedText = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString();
        }
        public void Fonts()
        {
            var fd = new FontDialog() { Font= mainTextBox.SelectionFont ,Color= mainTextBox.SelectionColor};
            if (fd.ShowDialog() != DialogResult.OK) return;
            mainTextBox.SelectionFont = fd.Font;
            mainTextBox.SelectionColor = fd.Color;
        }

        public void Find()
        {
            sf = new SearchForm(sa, FindNext);
            sf.Show();
        }

        public void Replace()
        {
            rf = new ReplaseForm(sa,FindNext,MakeReplace,ReplaseAll);
            rf.Show();
        }

        public void FindNext()
        {
                var com = StringComparison.Ordinal;
                if (!sa.Case)
                    com = StringComparison.OrdinalIgnoreCase;
                int index=0;
                if (sa.Direction)
                {
                    index=mainTextBox.Text.IndexOf(sa.Text, mainTextBox.SelectionStart + mainTextBox.SelectionLength, com);
                }
                else
                {
                    index=mainTextBox.Text.LastIndexOf(sa.Text, mainTextBox.SelectionStart - mainTextBox.SelectionLength, com);
                }
            if(index!=-1){
                mainTextBox.Select(index,sa.Text.Length);
                mainTextBox.Focus();
            }else{
                MessageBox.Show(Messages.CantFind);
            }                          
        }

        public void GoToLine()
        {
            var gtlForm = new GoToLineForm();
            if (gtlForm.ShowDialog() != DialogResult.OK) return;

            if (gtlForm.line.Value <= mainTextBox.Lines.Length)
            {
                mainTextBox.SelectionStart = 0;
                for (int i = 0; i < gtlForm.line.Value - 1; i++)
                {
                    mainTextBox.SelectionStart += mainTextBox.Lines[i].Length + 2;
                }
                mainTextBox.Focus();
            }
            else { MessageBox.Show(Messages.GotoError); }
        }

        public void Fat(bool ch)
        {
            int start = mainTextBox.SelectionStart, lenght = mainTextBox.SelectionLength;
            RichTextBox tmp = new RichTextBox() { Rtf = mainTextBox.SelectedRtf };
            for (int i = 0; i < lenght; i++)
            {
                tmp.Select(i, 1);
                if(ch)
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style | FontStyle.Bold);
                else
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style - (int)FontStyle.Bold);
            }
            mainTextBox.SelectedRtf = tmp.Rtf.Remove(tmp.Rtf.Length - 5);
            mainTextBox.Select(start, lenght);           
        }

        public void Underline(bool ch)
        {
            int start = mainTextBox.SelectionStart, lenght = mainTextBox.SelectionLength;
            RichTextBox tmp = new RichTextBox() { Rtf = mainTextBox.SelectedRtf };
            for (int i = 0; i < lenght; i++)
            {
                tmp.Select(i, 1);
                if (ch)
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style | FontStyle.Underline);
                else
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style - (int)FontStyle.Underline);
            }
            mainTextBox.SelectedRtf = tmp.Rtf.Remove(tmp.Rtf.Length - 5);
            mainTextBox.Select(start, lenght);
        }

        public void Italic(bool ch)
        {
            int start = mainTextBox.SelectionStart, lenght = mainTextBox.SelectionLength;
            RichTextBox tmp = new RichTextBox() { Rtf = mainTextBox.SelectedRtf };
            for (int i = 0; i < lenght; i++)
            {
                tmp.Select(i, 1);
                if (ch)
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style | FontStyle.Italic);
                else
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style - (int)FontStyle.Italic);
            }
            mainTextBox.SelectedRtf = tmp.Rtf.Remove(tmp.Rtf.Length - 5);
            mainTextBox.Select(start, lenght);
        }

        public void Strikeout(bool ch)
        {
            int start = mainTextBox.SelectionStart, lenght = mainTextBox.SelectionLength;
            RichTextBox tmp = new RichTextBox() { Rtf = mainTextBox.SelectedRtf };
            for (int i = 0; i < lenght; i++)
            {
                tmp.Select(i, 1);
                if (ch)
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style | FontStyle.Strikeout);
                else
                    tmp.SelectionFont = new Font(tmp.SelectionFont, tmp.SelectionFont.Style - (int)FontStyle.Strikeout);
            }
            mainTextBox.SelectedRtf = tmp.Rtf.Remove(tmp.Rtf.Length - 5);
            mainTextBox.Select(start, lenght);
        }

        public void PlusFont()
        {
            int start=mainTextBox.SelectionStart,lenght=mainTextBox.SelectionLength;
            RichTextBox tmp = new RichTextBox() { Rtf=mainTextBox.SelectedRtf};
            for (int i = 0; i < lenght; i++)
            {
                tmp.Select(i, 1);
                tmp.SelectionFont = new Font(tmp.SelectionFont.FontFamily, tmp.SelectionFont.Size + 1, tmp.SelectionFont.Style);
            }
            mainTextBox.SelectedRtf = tmp.Rtf.Remove(tmp.Rtf.Length - 5);
            mainTextBox.Select(start, lenght);
        }

        public void MinusFont()
        {
            int start = mainTextBox.SelectionStart, lenght = mainTextBox.SelectionLength;
            RichTextBox tmp = new RichTextBox() { Rtf = mainTextBox.SelectedRtf };
            for (int i = 0; i < lenght; i++)
            {
                tmp.Select(i, 1);
                if (mainTextBox.SelectionFont.Size - 1 > 0)
                    tmp.SelectionFont = new Font(tmp.SelectionFont.FontFamily, tmp.SelectionFont.Size - 1, tmp.SelectionFont.Style);
            }
            mainTextBox.SelectedRtf = tmp.Rtf.Remove(tmp.Rtf.Length-5);
            mainTextBox.Select(start, lenght);
        }

        public void ToRight()
        {
            mainTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        public void ToLeft()
        {
            mainTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        public void ToCenter()
        {
            mainTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void ForeColors()
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = mainTextBox.SelectionColor;
            if (cd.ShowDialog() == DialogResult.OK)
                mainTextBox.SelectionColor = cd.Color;
        }

        public void BackColors()
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = mainTextBox.SelectionBackColor;
            if (cd.ShowDialog() == DialogResult.OK)
                mainTextBox.SelectionBackColor = cd.Color;
        }

        public void Bullet()
        {
            mainTextBox.SelectionBullet = !mainTextBox.SelectionBullet;
        }

        private void InternalSave()
        {
            var type = Path.GetExtension(FileName) == ".rtf" ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
            mainTextBox.SaveFile(FileName, type);
        }

        private void ReplaseAll()
        {
            if (sa.Text.Length > 0)
                mainTextBox.Text = mainTextBox.Text.Replace(sa.Text, sa.NewText);
            mainTextBox.Focus();
        }

        private void MakeReplace()
        {
            var com = StringComparison.Ordinal;
            if (!sa.Case)
                com = StringComparison.OrdinalIgnoreCase;
            if (mainTextBox.Text.IndexOf(sa.Text, mainTextBox.SelectionStart + mainTextBox.SelectionLength, com) != -1)
            {
                mainTextBox.Select(mainTextBox.Text.IndexOf(sa.Text, mainTextBox.SelectionStart + mainTextBox.SelectionLength, com), sa.Text.Length);
                mainTextBox.SelectedText = sa.NewText;
                mainTextBox.Focus();
            }
        }

        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((File.Exists(FileName) && mainTextBox.Text != File.ReadAllText(FileName)) || (FileName == string.Empty && mainTextBox.Text != string.Empty))
            {
                DialogResult result = MessageBox.Show(Messages.SaveChanges, Messages.DialogTitle, MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
                if (result != DialogResult.Cancel)
                {
                    Hide();
                }
            }
        }

        private void NotepadForm_DragEnter(object sender, DragEventArgs e)
        {
            if ((string[])e.Data.GetData(DataFormats.FileDrop, true) == null) return;
            var l=((string[])e.Data.GetData(DataFormats.FileDrop, true)).Length;
                if (l > 1)
                    e.Effect = DragDropEffects.None;
                else if(l==1)
                    e.Effect = DragDropEffects.All;
        }

        private void NotepadForm_DragDrop(object sender, DragEventArgs e)
        {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                if (files == null) return;
                if (files.Length > 1)
                {
                    mainTextBox.SelectedText = string.Empty;
                    foreach (var file in files)
                    {
                        mainTextBox.SelectedText += File.ReadAllText(file);
                    }
                }else if(files.Length==1 && File.Exists(files[0]))
                {
                    mainTextBox.SelectedText=File.ReadAllText(files[0]);
                }
        }
    }
}