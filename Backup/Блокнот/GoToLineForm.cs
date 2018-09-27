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
    public partial class GoToLineForm : Form
    {
        public GoToLineForm()
        {
            InitializeComponent();
        }

        private void lineNom_Click(object sender, EventArgs e)
        {
            line.Focus();
        }
    }
}
