using Generator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotTryToEscapeFormKirow
{
    partial class Permission : MovebleControls
    {
        public Permission()
        {
            InitializeComponent();
        }

        private void Permission_Load(object sender, EventArgs e)
        {
            this.Size = BackgroundImage.Size;
        }
        public void setInfo(OriginalPermission p)
        {
            KName.Text = p.Name;
            LName.Left = KName.Left + KName.Width;
            LName.Text = p.LastName;
            Id.Text = p.Id.ToString();
            setStamp(p);
        }
        public void setStamp(OriginalPermission p)
        {
            NameIa.Text = p.LastNameIana;
            LnameIa.Left = NameIa.Left + NameIa.Width;
            LnameIa.Text = p.NameIana;
            pictureBox1.Image = Properties.Resources.IanaPechat;
        }
    }
}
