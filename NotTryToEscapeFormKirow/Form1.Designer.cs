using System.Windows.Forms;
using Generator;
using MultiPage;


namespace NotTryToEscapeFormKirow
{
    partial class Form1 : Form
    {

        private System.ComponentModel.IContainer components = null;


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
            SuspendLayout();
            // 
            // formGame1
            // 
            formGame1.BackgroundImage = (Image)resources.GetObject("formGame1.BackgroundImage");
            formGame1.Location = new Point(-1, 1);
            formGame1.Name = "formGame1";
            formGame1.Size = new Size(188, 188);
            formGame1.TabIndex = 5;
            formGame1.label2.Click += openMenu;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(formGame1);
            Name = "Form1";
            Text = "Don't try escape from Kirov";
            Load += Form1_Load;
            KeyDown += FormGame_KeyDown;
            ResumeLayout(false);
        }

        #endregion
        MainMenu.MainMenuPage MainMenu;
        Page Description;
        Rules.RulesPage Rules;


        private Label label1;
        private FormGame formGame1;
    }
}