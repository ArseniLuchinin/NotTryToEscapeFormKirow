using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiPage;

namespace NotTryToEscapeFormKirow
{
    partial class Form1 : Form
    {   
        private String[] DesFile = Properties.Resources.gameDescription.Split('\n');
        private void DescriptionInicize()
        {
            label1 = new Label();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Arial Narrow", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 969);
            label1.Name = "label1";
            label1.Size = new Size(0, 64);
            label1.TabIndex = 0;
            label1.Visible = false;
            label1.Click += Description_Click;


            Controls.Add(label1);

            Description = new Page(
                label1
                );
            Description.OpenEvent += OpenDiscription;
        }

        private void OpenDiscription(object sender, EventArgs e)
        {
            ClickIndex = 0;
            this.BackgroundImage = Properties.Resources.Dis;
            label1.Text = DesFile[ClickIndex];
        }
        int ClickIndex = 0;
        private void Description_Click(object sender, EventArgs e)
        {
            
            if (++ClickIndex >= DesFile.Length)
            {
                Description.Close();
                Rules.Open();
            }
            else label1.Text = DesFile[ClickIndex];
            
        }
    }
}
