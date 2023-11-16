using MultiPage;
using NotTryToEscapeFormKirow.Properties;

namespace Rules
{
    class RulesPage : Page
    {
        public PictureBox Instruction1 { get; private set; }
        public PictureBox Inxtruction2 { get; private set; }
        public Button OutBtn { get; private set; }
        private void RulesIniciaze()
        {
            
            // 
            // pictureBox2
            // 
            Instruction1.BackColor = Color.Transparent;
            Instruction1.Image = Resources.Instruction1;
            Instruction1.Location = new Point(128, 12);
            Instruction1.Name = "pictureBox2";
            Instruction1.Size = new Size(808, 1009);
            Instruction1.SizeMode = PictureBoxSizeMode.StretchImage;
            Instruction1.TabIndex = 3;
            Instruction1.TabStop = false;
            Instruction1.Visible = false;
            // 
            // pictureBox1
            // 
            Inxtruction2.BackColor = Color.Transparent;
            Inxtruction2.Image = Resources.Instruction2;
            Inxtruction2.Location = new Point(961, 12);
            Inxtruction2.Name = "pictureBox3";
            Inxtruction2.Size = new Size(808, 1009);
            Inxtruction2.SizeMode = PictureBoxSizeMode.StretchImage;
            Inxtruction2.TabIndex = 3;
            Inxtruction2.TabStop = false;
            Inxtruction2.Visible = false;


            OutBtn.Location = new Point(0, 0);
            OutBtn.Name = "b4";
            OutBtn.Size = new Size(100, 50);
            OutBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            OutBtn.FlatAppearance.BorderSize = 0;
            OutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            OutBtn.FlatAppearance.MouseOverBackColor = Color.Maroon;
            OutBtn.FlatStyle = FlatStyle.Flat;
            OutBtn.TabIndex = 4;
            OutBtn.BackColor = Color.Maroon;
            OutBtn.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            OutBtn.Text = "Назад";
            OutBtn.Visible = false;
        }
        public RulesPage(Control.ControlCollection c)
        {
            Instruction1 = new PictureBox();
            Inxtruction2 = new PictureBox();
            OutBtn = new Button();

            RulesIniciaze();

            c.Add(OutBtn);
            c.Add(Instruction1);
            c.Add(Inxtruction2);

            Elements = new Control[] { OutBtn, Inxtruction2, Instruction1 };
        }
    }
}
