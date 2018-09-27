using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notepad
{
    public class SearchArgs
    {
        public string NewText { get; set; }
        public string Text { get; set; }
        public bool Case { get; set; }
        public bool Direction { get; set; }
        public SearchArgs()
        {
            NewText = string.Empty;
            Text = string.Empty;
            Case = false;
            Direction = true;
        }
    }
}
