using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotTryToEscapeFormKirow
{
    partial class Form1
    {
        private void MainMenuInicize()
        {
            GameName = new Label();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.AutoSize = true;
            button3.BackColor = Color.Maroon;
            button3.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            button3.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(293, 813);
            button3.Name = "button3";
            button3.Size = new Size(559, 107);
            button3.TabIndex = 2;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.AutoSize = true;
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(293, 678);
            button1.Name = "button1";
            button1.Size = new Size(559, 107);
            button1.TabIndex = 0;
            button1.Text = "Описание";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.ErrorImage = null;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MainMenuKirow;
            pictureBox1.Location = new Point(1179, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 570);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.AutoSize = true;
            button2.BackColor = Color.Maroon;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(293, 545);
            button2.Name = "button2";
            button2.Size = new Size(559, 107);
            button2.TabIndex = 1;
            button2.Text = "Бесконечный режим";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            GameName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GameName.BackColor = Color.Transparent;
            GameName.BorderStyle = BorderStyle.None;
            GameName.Font = new Font("Impact", 56F, FontStyle.Regular, GraphicsUnit.Point);
            GameName.ForeColor = Color.Maroon;
            GameName.Location = new Point(70, 49);
            GameName.Name = "richTextBox1";
            GameName.Size = new Size(1075, 245);
            GameName.TabIndex = 4;
            GameName.Text = "Не пытайтесь покинуть Киров";
            GameName.Visible = false;

            Controls.Add(GameName);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
        }
    }
}
