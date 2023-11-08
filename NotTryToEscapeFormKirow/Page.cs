using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    class Page
    {
        private Control[] Elements;
        Form MainForm;
        Color BackColor;
        public Page(Form f, Color c,params Control[] arr)
        {
            Elements = arr;
            //MainForm = f;
            //BackColor = c;
            //Open();
        }
        public void Close() {
            foreach (Control c in Elements) 
                c.Visible = false;
            //MainForm.BackColor = Color.White;
        }
        public void Open()
        {
            foreach (Control c in Elements)
                c.Visible = true;
            //MainForm.BackColor = BackColor;
        }
    }
}
