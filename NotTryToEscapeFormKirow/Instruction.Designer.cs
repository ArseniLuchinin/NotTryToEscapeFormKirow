namespace NotTryToEscapeFormKirow
{
    partial class Instruction
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Information = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Information
            // 
            Information.AutoSize = true;
            Information.BackColor = Color.Maroon;
            Information.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Information.Location = new Point(0, 780);
            Information.MinimumSize = new Size(1920, 300);
            Information.Name = "Information";
            Information.Size = new Size(1920, 300);
            Information.TabIndex = 0;
            Information.Text = "label1";
            Information.Click += Information_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(272, 60);
            button1.TabIndex = 1;
            button1.Text = "Вернуться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Instruction2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(929, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 959);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Instruction1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(367, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(582, 959);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Instruction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dis;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(Information);
            Name = "Instruction";
            Size = new Size(1920, 1080);
            Load += Instruction_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Information;
        public Button button1 { get; private set; }
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
