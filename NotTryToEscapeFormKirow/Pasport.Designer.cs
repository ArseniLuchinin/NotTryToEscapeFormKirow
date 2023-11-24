namespace NotTryToEscapeFormKirow
{
    partial class FormPasport
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
            Foto = new PictureBox();
            Name = new Label();
            LastName = new Label();
            DataName = new Label();
            DatePasport = new Label();
            BornDate = new Label();
            ((System.ComponentModel.ISupportInitialize)Foto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            Foto.BackgroundImageLayout = ImageLayout.Stretch;
            Foto.Image = Properties.Resources.hVRJZhy0kS8;
            Foto.Location = new Point(35, 157);
            Foto.Name = "pictureBox1";
            Foto.Size = new Size(300, 350);
            Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            Foto.TabIndex = 0;
            Foto.TabStop = false;
            // 
            // label1
            // 
            Name.AutoSize = true;
            Name.BackColor = Color.Transparent;
            Name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(421, 80);
            Name.Name = "label1";
            Name.Size = new Size(97, 41);
            Name.TabIndex = 1;
            Name.Text = "label1";
            // 
            // label2
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.Location = new Point(385, 192);
            LastName.Name = "label2";
            LastName.Size = new Size(97, 41);
            LastName.TabIndex = 2;
            LastName.Text = "label2";
            // 
            // label3
            // 
            DataName.AutoSize = true;
            DataName.BackColor = Color.Transparent;
            DataName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataName.Location = new Point(337, 458);
            DataName.Name = "label3";
            DataName.Size = new Size(74, 20);
            DataName.TabIndex = 3;
            DataName.Text = "Годен до:";
            // 
            // label4
            // 
            DatePasport.AutoSize = true;
            DatePasport.BackColor = Color.Transparent;
            DatePasport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DatePasport.Location = new Point(417, 450);
            DatePasport.Name = "label4";
            DatePasport.Size = new Size(54, 28);
            DatePasport.TabIndex = 4;
            DatePasport.Text = "Дата";
            // 
            // label5
            // 
            BornDate.AutoSize = true;
            BornDate.BackColor = Color.Transparent;
            BornDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BornDate.Location = new Point(590, 313);
            BornDate.Name = "label5";
            BornDate.Size = new Size(147, 28);
            BornDate.TabIndex = 5;
            BornDate.Text = "ДатаРождения";
            // 
            // Pasport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pasport;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(BornDate);
            Controls.Add(DatePasport);
            Controls.Add(DataName);
            Controls.Add(LastName);
            Controls.Add(Name);
            Controls.Add(Foto);
            base.Name = "Pasport";
            Size = new Size(1023, 525);
            ((System.ComponentModel.ISupportInitialize)Foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Foto;
        private Label Name;
        private Label LastName;
        private Label DataName;
        private Label DatePasport;
        private Label BornDate;
    }
}
