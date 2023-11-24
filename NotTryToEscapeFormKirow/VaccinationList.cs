using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generator;

namespace NotTryToEscapeFormKirow
{
    partial class FormVaccinationList : UserControl
    {

        public void setVCList(VaccinationList list)
        {
            label1.Text = "";
            
            foreach (var i in list.getVaccine())
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
