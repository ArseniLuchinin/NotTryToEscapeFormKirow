using System.Windows.Forms;
using Generator;

namespace NotTryToEscapeFormKirow
{
    partial class Form1 : Form
    {

        private System.ComponentModel.IContainer components = null;
        Player player;

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
            startMenu1 = new StartMenu();
            instruction1 = new Instruction();
            SuspendLayout();
            // 
            // formGame1
            // 
            formGame1.BackgroundImage = (Image)resources.GetObject("formGame1.BackgroundImage");
            formGame1.Location = new Point(0, 0);
            formGame1.Name = "formGame1";
            formGame1.Size = new Size(188, 188);
            formGame1.TabIndex = 5;
            // 
            // startMenu1
            // 
            startMenu1.BackgroundImage = (Image)resources.GetObject("startMenu1.BackgroundImage");
            startMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            startMenu1.Location = new Point(0, 0);
            startMenu1.Name = "startMenu1";
            startMenu1.Size = new Size(1920, 1080);
            startMenu1.TabIndex = 9;
            // 
            // instruction1
            // 
            instruction1.BackgroundImage = (Image)resources.GetObject("instruction1.BackgroundImage");
            instruction1.BackgroundImageLayout = ImageLayout.Stretch;
            instruction1.Location = new Point(0, 0);
            instruction1.Name = "instruction1";
            instruction1.Size = new Size(2400, 1350);
            instruction1.TabIndex = 10;
            instruction1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(startMenu1);
            Controls.Add(instruction1);
            Controls.Add(formGame1);
            Name = "Form1";
            Text = "Don't try escape from Kirov";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += FormGame_KeyDown;
            ResumeLayout(false);
        }

        #endregion


        private Label label1;
        private FormGame formGame1;
        private StartMenu startMenu1;
        private Instruction instruction1;
    }
}