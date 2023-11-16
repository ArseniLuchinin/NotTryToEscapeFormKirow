using System.Windows.Forms;
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
        MainMenu.MainMenuPage MainMenu;
        Page Description;
        Rules.RulesPage Rules;

        
        private Label label1;
    }
}