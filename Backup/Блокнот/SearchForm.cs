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
    public partial class SearchForm : Form
    {
        int _index;
        public SearchForm()
        {
            InitializeComponent();
            _index = -serchingFild.TextLength;            
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

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (up.Checked)
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
                    if (NotepadForm.GetNotepadForm().mainTextBox.SelectionStart - 1 > 0 && NotepadForm.GetNotepadForm().mainTextBox.Text.LastIndexOf(serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart - 1, com) != -1)
                    {
                        NotepadForm.GetNotepadForm().mainTextBox.Select(NotepadForm.GetNotepadForm().mainTextBox.Text.LastIndexOf(serchingFild.Text, NotepadForm.GetNotepadForm().mainTextBox.SelectionStart - 1, com), serchingFild.TextLength);
                        NotepadForm.GetNotepadForm().mainTextBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найдено!");
                    }
                }
            }
            else if(down.Checked)
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
        }
    }
}
