using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI03_2_ClassLibrary
{
    public class ChangeTextBoxTextArgs : EventArgs
    {
        private string text;
        public string Text
        {
            get { return text; }
        }

        public ChangeTextBoxTextArgs(String t) : base()
        {
            text = t;
        }
    }
}
