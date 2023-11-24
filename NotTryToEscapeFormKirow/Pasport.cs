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
    partial class FormPasport : UserControl
    {
        public FormPasport()
        {
            InitializeComponent();
        }
        public void SetPasport(Generator.PasportGenerator p)
        {
            Name.Text = p.Name;
            LastName.Text = p.LastName;
            DatePasport.Text = p.DatePasport.ToString();
            BornDate.Text = p.BornDate.ToString();
            Foto.Image = p.Foto;
        }
    }
}
