using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class ReplaseForm : Form
    {
        public ReplaseForm()
        {
            InitializeComponent();
        }

        private void fildName_Click(object sender, EventArgs e)
        {
            serchingFild.Focus();
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose(false);
        }

        private void fildRName_Click(object sender, EventArgs e)
        {
            replaseFild.Focus();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
                var com = StringComparison.Ordinal;
                if (!tolower.Checked)
                    com = StringComparison.OrdinalIgnoreCase;

                if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart == 0 && NotepadForm.GetNotepadForm().mainTextBox.Text.Substring(0, serchingFild.TextLength) == serchingFild.Text)
                {
                    NotepadForm.GetNotepadForm().mainTextBox.Select(0, serchingFild.TextLength);
                    NotepadForm.GetNotepadForm().mainTextBox.Focus();
                }
                else
                {
                    if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1 <= NotepadForm.GetNotepadForm().mainTextBox.TextLength && NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1, com) != -1)
                    {
                        NotepadForm.GetNotepadForm().mainTextBox.Select(NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart + 1, com), serchingFild.TextLength);
                        NotepadForm.GetNotepadForm().mainTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
        }
        internal String Replace(String text, int index,String oldStr, String newStr)
        {
            return text.Remove(index, oldStr.Length).Insert(index, newStr);
        }
        private void replase_Click(object sender, EventArgs e)
        {
            if (replaseFild.Text != "")
            {
                var com = StringComparison.Ordinal;
                if (!tolower.Checked)
                    com = StringComparison.OrdinalIgnoreCase;
                if (NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart, com) != -1)
                {
                    int start = NotepadForm.GetNotepadForm().mainTextBox.Text.IndexOf(serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart, com);
                    NotepadForm.GetNotepadForm().mainTextBox.Text = Replace(NotepadForm.GetNotepadForm().mainTextBox.Text, start, serchingFild.Text, replaseFild.Text);
                    NotepadForm.GetNotepadForm().mainTextBox.SelectionStart = start;
                    NotepadForm.GetNotepadForm().mainTextBox.SelectionLength = replaseFild.TextLength;
                    NotepadForm.GetNotepadForm().mainTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Совпадений не найдено!");
                }
            }
        }

        private void replaseAll_Click(object sender, EventArgs e)
        {
            if(replaseFild.Text!="")
                NotepadForm.GetNotepadForm().mainTextBox.Text = NotepadForm.GetNotepadForm().mainTextBox.Text.Replace(serchingFild.Text, replaseFild.Text);
        }
    }
}
