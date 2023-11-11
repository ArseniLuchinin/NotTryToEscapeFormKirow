using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTryToEscapeFormKirow
{
    partial class Form1 : Form
    {
        private void RulesIniciaze()
        {
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Instruction1;
            pictureBox2.Location = new Point(128, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(808, 1009);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Instruction2;
            pictureBox3.Location = new Point(961, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(808, 1009);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;


            button4.Location = new Point(0, 0);
            button4.Name = "b4";
            button4.Size = new Size(100, 50);
            button4.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button4.FlatStyle = FlatStyle.Flat;
            button4.TabIndex = 4;
            button4.BackColor = Color.Maroon;
            button4.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Text = "Назад";
            button4.Visible = false;
            button4.Click += OutInMenu;

            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button4);


            Rules = new Page(
                pictureBox3,
                pictureBox2,
                button4
                );
        }
        private void OutInMenu(object sender, EventArgs e)
        {
            if(Rules.isOpen)
            {
                Rules.Close();
                MainMenu.Open();
            }
        }
    }
}
