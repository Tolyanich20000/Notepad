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
        SearchArgs args;

        public SearchForm(SearchArgs searchArgs, Action nextClick)
        {
            InitializeComponent();
            args = searchArgs;
            serchingFild.Text = args.Text;
            down.Checked = args.Direction;
            tolower.Checked = args.Case;
            nextBtn.Click += (s, e) => nextClick();
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

        private void serchingFild_TextChanged(object sender, EventArgs e)
        {
            args.Text = serchingFild.Text;
        }

        private void up_CheckedChanged(object sender, EventArgs e)
        {
            args.Direction = false;
        }

        private void down_CheckedChanged(object sender, EventArgs e)
        {
            args.Direction = true;
        }

        private void tolower_CheckedChanged(object sender, EventArgs e)
        {
            args.Case = tolower.Checked;
        }
    }
}
