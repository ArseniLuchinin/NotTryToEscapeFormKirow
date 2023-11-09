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
        public event EventHandler OpenEvent;
        public event EventHandler CloseEvent;
        public Page(params Control[] arr)
        {
            Elements = arr;
        }
        public void Close() {
            foreach (Control c in Elements) 
                c.Visible = false;

            CloseEvent(this, new EventArgs());
        }
        public void Open()
        {   
            foreach (Control c in Elements)
                c.Visible = true;

            OpenEvent(this, new EventArgs());
        }
    }
}
