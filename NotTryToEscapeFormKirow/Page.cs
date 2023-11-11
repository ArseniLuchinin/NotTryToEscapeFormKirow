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
        public bool isOpen { get; private set; }
        private Control[] Elements;
        public event EventHandler OpenEvent;
        public event EventHandler CloseEvent;
        public Page(params Control[] arr)
        {
            Elements = arr;
        }
        public void Close() {
            isOpen = false;
            foreach (Control c in Elements) 
                c.Visible = false;

           if(CloseEvent!=null)
                CloseEvent(this, new EventArgs());
        }
        public void Open()
        {
            isOpen = true;
            foreach (Control c in Elements)
                c.Visible = true;

            if(OpenEvent != null)
                OpenEvent(this, new EventArgs());
        }
    }
}
