using System.Windows.Forms;
using Generator;
using MultiPage;


namespace NotTryToEscapeFormKirow
{
    partial class Form1 : Form
    {

        private System.ComponentModel.IContainer components = null;
        Player player = new Player();

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            formGame1 = new FormGame();
            PlayerName = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // formGame1
            // 
            formGame1.BackgroundImage = (Image)resources.GetObject("formGame1.BackgroundImage");
            formGame1.Location = new Point(-1, 1);
            formGame1.Name = "formGame1";
            formGame1.Size = new Size(188, 188);
            formGame1.TabIndex = 5;
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.BackColor = Color.Transparent;
            PlayerName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerName.ForeColor = Color.White;
            PlayerName.Location = new Point(1662, 9);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(0, 41);
            PlayerName.TabIndex = 6;
            PlayerName.Click += PlayerName_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Maroon;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(1662, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 47);
            textBox1.TabIndex = 7;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(textBox1);
            Controls.Add(PlayerName);
            Controls.Add(formGame1);
            Name = "Form1";
            Text = "Don't try escape from Kirov";
            Load += Form1_Load;
            KeyDown += FormGame_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        MainMenu.MainMenuPage MainMenu;
        Page Description;
        Rules.RulesPage Rules;


        private Label label1;
        private FormGame formGame1;
        private Label PlayerName;
        private TextBox textBox1;
    }
}