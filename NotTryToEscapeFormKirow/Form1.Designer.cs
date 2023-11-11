using System.Windows.Forms;

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

            //SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Name = "Form1";
            Text = "Don't try escape from Kirov";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        Page MainMenu;
        Page Description;
        Page Rules;

        private Button button3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label GameName;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button4;
    }
}