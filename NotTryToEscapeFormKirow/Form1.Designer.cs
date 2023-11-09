using System.Windows.Forms;

namespace NotTryToEscapeFormKirow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1622, 1033);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Don't try escape from Kirov";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        Page MainMenu;
        Page Description;
        private Button button3;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label GameName;
        private Label label1;
    }
}