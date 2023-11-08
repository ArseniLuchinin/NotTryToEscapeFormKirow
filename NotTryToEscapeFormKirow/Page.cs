using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    class Page
    {
        private Control[] Elements;
        public Page(params Control[] arr)
        {
            Elements = arr;
        }
        public void Close() {
            foreach (Control c in Elements) 
                c.Visible = false;
        }
        public void Open()
        {
            foreach (Control c in Elements)
                c.Visible = true;
        }
    }
}
