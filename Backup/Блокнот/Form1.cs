using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Notepad
{
    public partial class NotepadForm : Form
    {
        static NotepadForm np;
        public static NotepadForm GetNotepadForm() {
            return np;
        }
        public NotepadForm()
        {
            InitializeComponent();
            mainTextBox.Size = new Size(mainTextBox.Size.Width, mainTextBox.Size.Height + statusStrip.Size.Height);
            cut.Enabled = false;
            copy.Enabled = false;
            delete.Enabled = false;
            find.Enabled = false;
            findNext.Enabled = false;
            np = this;
            replaseForm.TopMost = true;
            searchForm.TopMost = true;
        }
        static ReplaseForm replaseForm = new ReplaseForm();
        static SearchForm searchForm = new SearchForm();
        static GoToLineForm gtlForm = new GoToLineForm();
        private void open_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "" || openFileDialog.FileName != "")
            {
                DialogResult result = MessageBox.Show("Сохранить измененияв файле?", "Блокнот", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == result)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
                    }
                }
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                mainTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName != "")
            {
                File.WriteAllText(openFileDialog.FileName, mainTextBox.Text);
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
                openFileDialog.FileName = saveFileDialog.FileName;
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
                openFileDialog.FileName = saveFileDialog.FileName;
            }
        }

        private void parameters_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog.ShowDialog();
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void font_Click(object sender, EventArgs e)
        {      
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.Font = fontDialog.Font;
            }
        }

        private void status_Click(object sender, EventArgs e)
        {
            if (status.Checked)
            {
                status.Checked = false;
                statusStrip.Visible = false;
                mainTextBox.Size = new Size(mainTextBox.Size.Width, mainTextBox.Size.Height + statusStrip.Size.Height);
            }
            else if(statusStrip.Size.Height<Size.Height){
                status.Checked = true;
                statusStrip.Visible = true;
                mainTextBox.Size = new Size(mainTextBox.Size.Width, mainTextBox.Size.Height - statusStrip.Size.Height);
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mainTextBox.Text == "")
            {                
                find.Enabled = false;
                findNext.Enabled = false;
                goTo.Enabled = false;
            }
            else
            {         
                find.Enabled = true;
                findNext.Enabled = true;
                goTo.Enabled = true;
            }
            if (mainTextBox.SelectionLength == 0)
            {
                cut.Enabled = false;
                copy.Enabled = false;
                delete.Enabled = false;
            }
            else
            {
                cut.Enabled = true;
                copy.Enabled = true;
                delete.Enabled = true;
            }
            Str.Text = mainTextBox.Text.Length.ToString();
            Stl.Text = mainTextBox.Lines.Length.ToString();
        }

        private void find_Click(object sender, EventArgs e)
        {
            searchForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainTextBox.Text != "" || openFileDialog.FileName != "")
            {
                DialogResult result = MessageBox.Show("Сохранить измененияв файле?", "Блокнот", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == result)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
                        Environment.Exit(0);
                    }
                }
                if (DialogResult.No == result)
                {
                    Environment.Exit(0);
                }
                e.Cancel = true;
            }
            else Environment.Exit(0);
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бла-бла-бла писав Толян", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text != "" || openFileDialog.FileName != "")
            {
                DialogResult result = MessageBox.Show("Сохранить измененияв файле?", "Блокнот", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == result)
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
                        mainTextBox.Text = "";
                    }
                }
                if (DialogResult.No == result)
                {
                    mainTextBox.Text = "";
                }
            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            mainTextBox.Undo();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            mainTextBox.Copy();
        }

        private void put_Click(object sender, EventArgs e)
        {
            mainTextBox.Paste();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var start=mainTextBox.SelectionStart;
            if (start!=mainTextBox.Text.Length && mainTextBox.SelectionLength==0)
                mainTextBox.Text=mainTextBox.Text.Remove(start, 1);
            else
                mainTextBox.Text = mainTextBox.Text.Remove(start, mainTextBox.SelectionLength);
            mainTextBox.SelectionStart = start;
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            mainTextBox.SelectAll();
        }

        private void date_Click(object sender, EventArgs e)
        {
            mainTextBox.Text += DateTime.Now.ToShortTimeString()+" "+DateTime.Now.ToShortDateString();
        }

        private void openReadme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бла-бла-бла блокнот", "Справка", MessageBoxButtons.OK , MessageBoxIcon.Question);
        }
        private void wordWarp_Click(object sender, EventArgs e)
        {
            if (wordWarp.Checked)
            {
                wordWarp.Checked = false;
                mainTextBox.WordWrap = false;
            }
            else
            {               
                wordWarp.Checked = true;
                mainTextBox.WordWrap = true;
            }
            Str.Text = mainTextBox.Text.Length.ToString();
            Stl.Text = mainTextBox.Lines.Length.ToString();
        }

        private void replase_Click(object sender, EventArgs e)
        {
            replaseForm.Show();
        }

        private void goTo_Click(object sender, EventArgs e)
        {
            if (gtlForm.ShowDialog() == DialogResult.OK)
            {
                if (gtlForm.line.Value <= mainTextBox.Lines.Length)
                {
                    mainTextBox.SelectionStart = 0;
                    for (int i = 0; i < gtlForm.line.Value-1; i++)
                    {
                        mainTextBox.SelectionStart += mainTextBox.Lines[i].Length+2;
                    }
                    mainTextBox.Focus();
                }
                else { MessageBox.Show("Номер строки превышает общее число строк"); }
            }
        }

        private void findNext_Click(object sender, EventArgs e)
        {
            if (searchForm.serchingFild.Text != "") {
                if (searchForm.up.Checked)
                {
                    var com = StringComparison.Ordinal;
                    if (!searchForm.tolower.Checked)
                        com = StringComparison.OrdinalIgnoreCase;

                    if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart == 0 && NotepadForm.GetNotepadForm().mainTextBox.Text.Substring(0, searchForm.serchingFild.TextLength) == searchForm.serchingFild.Text)
                    {
                        NotepadForm.GetNotepadForm().mainTextBox.Select(0, searchForm.serchingFild.TextLength);
                        NotepadForm.GetNotepadForm().mainTextBox.Focus();
                    }
                    else
                    {
                        if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart - 1 > 0 && NotepadForm.GetNotepadForm().mainTextBox.Text.LastIndexOf(searchForm.serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart - 1, com) != -1)
                        {
                            NotepadForm.GetNotepadForm().mainTextBox.Select(NotepadForm.GetNotepadForm().mainTextBox.Text.LastIndexOf(searchForm.serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart - 1, com), searchForm.serchingFild.TextLength);
                            NotepadForm.GetNotepadForm().mainTextBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Совпадений не найдено!");
                        }
                    }
                }
                else if (searchForm.down.Checked)
                {
                    var com = StringComparison.Ordinal;
                    if (!searchForm.tolower.Checked)
                        com = StringComparison.OrdinalIgnoreCase;

                    if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart == 0 && NotepadForm.GetNotepadForm().mainTextBox.Text.Substring(0, searchForm.serchingFild.TextLength) == searchForm.serchingFild.Text)
                    {
                        NotepadForm.GetNotepadForm().mainTextBox.Select(0, searchForm.serchingFild.TextLength);
                        NotepadForm.GetNotepadForm().mainTextBox.Focus();
                    }
                    else
                    {
                        if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1 <= NotepadForm.GetNotepadForm().mainTextBox.TextLength && NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(searchForm.serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1, com) != -1)
                        {
                            NotepadForm.GetNotepadForm().mainTextBox.Select(NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(searchForm.serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1, com), searchForm.serchingFild.TextLength);
                            NotepadForm.GetNotepadForm().mainTextBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Совпадений не найдено!");
                        }
                    }
                }
            }
            else if (replaseForm.serchingFild.Text != "") {
                var com = StringComparison.Ordinal;
                if (!replaseForm.tolower.Checked)
                    com = StringComparison.OrdinalIgnoreCase;

                if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart == 0 && NotepadForm.GetNotepadForm().mainTextBox.Text.Substring(0, searchForm.serchingFild.TextLength) == searchForm.serchingFild.Text)
                {
                    NotepadForm.GetNotepadForm().mainTextBox.Select(0, replaseForm.serchingFild.TextLength);
                    NotepadForm.GetNotepadForm().mainTextBox.Focus();
                }
                else
                {
                    if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1 <= NotepadForm.GetNotepadForm().mainTextBox.TextLength && NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(searchForm.serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1, com) != -1)
                    {
                        NotepadForm.GetNotepadForm().mainTextBox.Select(NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(searchForm.serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1, com), searchForm.serchingFild.TextLength);
                        NotepadForm.GetNotepadForm().mainTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
        } else searchForm.Show();
        }
    }
}