using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotTryToEscapeFormKirow
{
    partial class FormVaccinationList : MovebleControls
    {

        public void setVCList(VaccinationList list)
        {
            label1.Text = "";

            foreach (var i in list)
            {
                label1.Text += Environment.NewLine + i;
            }

        }

        public FormVaccinationList()
        {
            InitializeComponent();
        }
    }
}
