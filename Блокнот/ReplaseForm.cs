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
        SearchArgs sa;
        public ReplaseForm(SearchArgs searchArgs, Action nextClick, Action replaceClick, Action replaceAllClick)
        {
            InitializeComponent();
            sa = searchArgs;
            serchingFild.Text = sa.Text;
            replaseFild.Text = sa.NewText;
            tolower.Checked = sa.Case;
            nextBtn.Click += (s, e) => nextClick();
            replase.Click += (s, e) => replaceClick();
            replaseAll.Click += (s, e) => replaceAllClick();
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

        private void serchingFild_TextChanged(object sender, EventArgs e)
        {
            sa.Text = serchingFild.Text;
        }

        private void replaseFild_TextChanged(object sender, EventArgs e)
        {
            sa.NewText = replaseFild.Text;
        }

        private void tolower_CheckedChanged(object sender, EventArgs e)
        {
            sa.Case = tolower.Checked;
        }
    }
}
