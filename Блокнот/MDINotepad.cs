using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class MDINotepad : Form
    {
        public MDINotepad(string[] args)
        {
            InitializeComponent();
            if (args == null || args.Length==0) return;
            CreateNewForm(args[0]);
            opened = true;
        }
        int nom = 0;
        bool opened=false;
        GoToLineForm gtlForm = new GoToLineForm();
        internal NotepadForm ActiveForm { get { return ActiveMdiChild as NotepadForm; } }
        private void MDINotepad_Load(object sender, EventArgs e)
        {
            if(!opened)
            CreateNewForm();
        }
        internal void CreateNewForm()
        {
            nom++;
            var form = new NotepadForm { MdiParent = this ,Text="Notepad"+nom};
            form.DragEnter += this.MDINotepad_DragEnter;
            form.DragDrop += this.MDINotepad_DragDrop;
            form.mainTextBox.DragEnter += this.MDINotepad_DragEnter;
            form.mainTextBox.DragDrop += this.MDINotepad_DragDrop;
            form.DocumentChanged += DocumentChanged;
            form.DocumentChanged += (s,e)=>UpdateTools();
            if (wind.Checked)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            form.Show();
        }

        private void DocumentChanged(object sender, EventArgs e)
        {
            if (ActiveForm == null) return;
            findToolStripMenuItem.Enabled = !ActiveForm.IsDocumentEmpty;
            replaseToolStripMenuItem.Enabled = !ActiveForm.IsDocumentEmpty;
            findNextToolStripMenuItem.Enabled = !ActiveForm.IsDocumentEmpty;
            goToToolStripMenuItem.Enabled = !ActiveForm.IsDocumentEmpty;
            cutToolStripMenuItem.Enabled = ActiveForm.IsSelected;
            copyToolStripMenuItem.Enabled = ActiveForm.IsSelected;
            deleteToolStripMenuItem.Enabled = ActiveForm.IsSelected;
            Str.Text = ActiveForm.mainTextBox.Text.Length.ToString();
            Stl.Text = ActiveForm.mainTextBox.Lines.Length.ToString();
        }

        internal void CreateNewForm(string path)
        {
            if (!File.Exists(path)) return;
            foreach(NotepadForm child in MdiChildren)
            {
                if (child.FileName == path)
                {
                    child.Activate();
                    return;
                }
            }
            nom++;
            var form = new NotepadForm(path){ MdiParent = this, Text = Path.GetFileName(path) };
            if (wind.Checked)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            form.Show();
        }
        private void MDINotepad_MdiChildActivate(object sender, EventArgs e)
        {
            var form = this.ActiveMdiChild as NotepadForm;
            if (form != null)
            {
                if (MdiChildren.Count() > 1)
                {
                    previusChild.Visible = true;
                    nextChild.Visible = true;
                }
                else
                {
                    previusChild.Visible = false;
                    nextChild.Visible = false;
                }
                if (wind.Checked)
                {
                    form.WindowState = FormWindowState.Maximized;
                }
                editToolStripMenuItem.Enabled = true;
                formatToolStripMenuItem.Enabled = true;
                toolsToolStripMenuItem.Enabled = true;
                helpToolStripMenuItem.Enabled = true;
                toolStrip.Visible = true;
                saveAsToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                printToolStripMenuItem.Enabled = true;
                printPreviewToolStripMenuItem.Enabled = true;
                kids.Enabled = true;
                UpdateTools();                
            }
            else
            {
                editToolStripMenuItem.Enabled = false;
                formatToolStripMenuItem.Enabled = false;
                toolsToolStripMenuItem.Enabled = false;
                helpToolStripMenuItem.Enabled = false;
                toolStrip.Visible = false;
                saveAsToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                printToolStripMenuItem.Enabled = false;
                printPreviewToolStripMenuItem.Enabled = false;
                kids.Enabled = false;
            }
            DocumentChanged(this,EventArgs.Empty);
        }
        private void UpdateTools()
        {
            fat.Checked = ActiveForm.IsBold;
            italic.Checked = ActiveForm.IsItalic;
            strikeout.Checked = ActiveForm.IsStrikeout;
            underline.Checked = ActiveForm.IsUnderline;
            right.Checked = ActiveForm.Alignment == HorizontalAlignment.Right;
            left.Checked = ActiveForm.Alignment == HorizontalAlignment.Left;
            center.Checked = ActiveForm.Alignment == HorizontalAlignment.Center;
            bullet.Checked = ActiveForm.IsBullet;
            undoToolStripMenuItem.Enabled = ActiveForm.CanUndo;
            redoToolStripMenuItem.Enabled = ActiveForm.CanRedo;
            undoBtn.Enabled = ActiveForm.CanUndo;
            redoBtn.Enabled = ActiveForm.CanRedo;
            foreColors.ForeColor = ActiveForm.Fore;
            backColors.BackColor = ActiveForm.Back;
        }

        private void vert_Click(object sender, EventArgs e)
        {
            vert.Checked = true;
            hor.Checked = false;
            wind.Checked = false;
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void hor_Click(object sender, EventArgs e)
        {
            vert.Checked = false;
            hor.Checked = true;
            wind.Checked = false;
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void wind_Click(object sender, EventArgs e)
        {
            vert.Checked = false;
            hor.Checked = false;
            wind.Checked = true;
            MDINotepad_MdiChildActivate(sender,e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewForm();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK)
                CreateNewForm(openFileDialog.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusToolStripMenuItem.Checked)
            {
                statusToolStripMenuItem.Checked = false;
                statusStrip.Visible = false;
            }
            else if (statusStrip.Size.Height < Size.Height)
            {
                statusToolStripMenuItem.Checked = true;
                statusStrip.Visible = true;

            }
        }

        private void wordWarpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWarpToolStripMenuItem.Checked)
            {
                wordWarpToolStripMenuItem.Checked = false;
                ActiveForm.WordWrap = false;
            }
            else
            {
                wordWarpToolStripMenuItem.Checked = true;
                ActiveForm.WordWrap = true;
            }
            Str.Text = ActiveForm.mainTextBox.Text.Length.ToString();
            Stl.Text = ActiveForm.mainTextBox.Lines.Length.ToString();
        }

        private void lookForHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бла-бла-бла блокнот", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бла-бла-бла писав Толян", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MDINotepad_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            if (files == null)
            {
                e.Effect = DragDropEffects.None;
                return;
            }
                foreach (var file in files)
                {
                    if (!File.Exists(file)) { e.Effect = DragDropEffects.None; return; }
                }
                e.Effect = DragDropEffects.Copy;
        }

        private void MDINotepad_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            if (files == null) return;
                foreach (var file in files)
                {
                    CreateNewForm(file);
                }
        }      

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Find();
        }
        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.FindNext();
        }

        private void replaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Replace();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Delelte();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.GoToLine();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.DateAndTime();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Fonts();
            UpdateTools();
        }

        private void fat_Click(object sender, EventArgs e)
        {
            ActiveForm.Fat(fat.Checked);
        }

        private void underline_Click(object sender, EventArgs e)
        {
            ActiveForm.Underline(underline.Checked);
        }

        private void italic_Click(object sender, EventArgs e)
        {
            ActiveForm.Italic(italic.Checked);
        }

        private void strikeout_Click(object sender, EventArgs e)
        {
            ActiveForm.Strikeout(strikeout.Checked);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Save();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.SaveAs();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.ShowPrint();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.ShowPageSetup();
        }

        private void plusFontSize_Click(object sender, EventArgs e)
        {
            ActiveForm.PlusFont();
        }

        private void minusFontSize_Click(object sender, EventArgs e)
        {
            ActiveForm.MinusFont();
        }

        private void center_Click(object sender, EventArgs e)
        {
            ActiveForm.ToCenter();
            UpdateTools();
        }

        private void left_Click(object sender, EventArgs e)
        {
            ActiveForm.ToLeft();
            UpdateTools();
        }

        private void right_Click(object sender, EventArgs e)
        {
            ActiveForm.ToRight();
            UpdateTools();
        }

        private void colors_Click(object sender, EventArgs e)
        {
            ActiveForm.ForeColors();
        }

        private void bullet_Click(object sender, EventArgs e)
        {
            ActiveForm.Bullet();
        }

        private void backColors_Click(object sender, EventArgs e)
        {
            ActiveForm.BackColors();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Redo();
        }

        private void previusChild_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0) return;
            if (ActiveMdiChild == MdiChildren.First())
            {
                MdiChildren.Last().Activate();
            }
            else
            {
                int i = 0;
                while (MdiChildren[i] != ActiveMdiChild) { i++; }
                MdiChildren[i - 1].Activate();
            }
        }

        private void nextChild_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length == 0) return;
            if (ActiveMdiChild == MdiChildren.Last())
            {
                MdiChildren.First().Activate();
            }
            else
            {
                int i = 0;
                while (MdiChildren[i] != ActiveMdiChild) { i++; }
                MdiChildren[i + 1].Activate();
            }
        }
    }
}
