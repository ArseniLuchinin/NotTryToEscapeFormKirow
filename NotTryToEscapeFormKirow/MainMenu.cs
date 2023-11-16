using MultiPage;
using NotTryToEscapeFormKirow.Properties;

namespace MainMenu
{
    
    class MainMenuPage : Page
    {
        public Button OutBtn { get; private set; }
        public Button DescriptionBtn { get; private set; }
        public PictureBox KirowMainPicture { get; private set; }
        public Button StartBtn { get; private set; }
        public Label GameName { get; private set; }
        private void Inicize()
        {
            
            // 
            // button3
            // 
            OutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OutBtn.AutoSize = true;
            OutBtn.BackColor = Color.Maroon;
            OutBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            OutBtn.FlatAppearance.BorderSize = 2;
            OutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            OutBtn.FlatAppearance.MouseOverBackColor = Color.Maroon;
            OutBtn.FlatStyle = FlatStyle.Flat;
            OutBtn.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            OutBtn.Location = new Point(293, 813);
            OutBtn.Name = "button3";
            OutBtn.Size = new Size(559, 107);
            OutBtn.TabIndex = 2;
            OutBtn.Text = "Выйти";
            OutBtn.UseVisualStyleBackColor = false;
            OutBtn.Visible = false;
            // 
            // button1
            // 
            DescriptionBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DescriptionBtn.AutoSize = true;
            DescriptionBtn.BackColor = Color.Maroon;
            DescriptionBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            DescriptionBtn.FlatAppearance.BorderSize = 2;
            DescriptionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            DescriptionBtn.FlatAppearance.MouseOverBackColor = Color.Maroon;
            DescriptionBtn.FlatStyle = FlatStyle.Flat;
            DescriptionBtn.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionBtn.Location = new Point(293, 678);
            DescriptionBtn.Name = "button1";
            DescriptionBtn.Size = new Size(559, 107);
            DescriptionBtn.TabIndex = 0;
            DescriptionBtn.Text = "Описание";
            DescriptionBtn.UseVisualStyleBackColor = false;
            DescriptionBtn.Visible = false;
            // 
            // pictureBox1
            // 
            KirowMainPicture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KirowMainPicture.ErrorImage = null;
            KirowMainPicture.BackColor = Color.Transparent;
            KirowMainPicture.Image = Resources.MainMenuKirow;
            KirowMainPicture.Location = new Point(1179, 0);
            KirowMainPicture.Name = "pictureBox1";
            KirowMainPicture.Size = new Size(443, 570);
            KirowMainPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            KirowMainPicture.TabIndex = 3;
            KirowMainPicture.TabStop = false;
            KirowMainPicture.Visible = false;
            // 
            // button2
            // 
            StartBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartBtn.AutoSize = true;
            StartBtn.BackColor = Color.Maroon;
            StartBtn.BackgroundImageLayout = ImageLayout.None;
            StartBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            StartBtn.FlatAppearance.BorderSize = 2;
            StartBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            StartBtn.FlatAppearance.MouseOverBackColor = Color.Maroon;
            StartBtn.FlatStyle = FlatStyle.Flat;
            StartBtn.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.Location = new Point(293, 545);
            StartBtn.Name = "button2";
            StartBtn.Size = new Size(559, 107);
            StartBtn.TabIndex = 1;
            StartBtn.Text = "Бесконечный режим";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Visible = false;
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
        }

        public MainMenuPage(Control.ControlCollection c)
        {

            GameName = new Label();
            OutBtn = new Button();
            DescriptionBtn = new Button();
            KirowMainPicture = new PictureBox();
            StartBtn = new Button();

            Inicize();
            c.Add(OutBtn);
            c.Add(StartBtn);
            c.Add(DescriptionBtn);
            c.Add(KirowMainPicture);
            c.Add(GameName);

            Elements = new Control[] {GameName, OutBtn, StartBtn, DescriptionBtn, KirowMainPicture};
        }
        
    }
}
