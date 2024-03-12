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
    public partial class Instruction : UserControl
    {
        String[] texts = Properties.Resources.gameDescription.Split('\n');
        public Instruction()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Information_Click(object sender, EventArgs e)
        {
            Information.Text = texts[i++];
            if (i >= texts.Length)
            {
                Information.Visible = false;
                pictureBox1.Visible = pictureBox2.Visible = true;
            }
        }

        private void Instruction_Load(object sender, EventArgs e)
        {
            Information.Text = texts[i++];
            pictureBox1.Visible = pictureBox2.Visible = false;
        }

        public void MakeFullSkreen(Form f)
        {
            this.Size = f.Size;
            Information.MinimumSize = new Size(f.Size.Width, Information.MinimumSize.Height);
            Information.MaximumSize = Information.MinimumSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            pictureBox1.Visible = pictureBox2.Visible = false;
        }
    }
}
