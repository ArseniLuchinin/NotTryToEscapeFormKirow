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
            NamePerson = new Label();
            LastName = new Label();
            DataName = new Label();
            DatePasport = new Label();
            BornDate = new Label();
            IDLabel = new Label();
            IDText = new Label();
            ((System.ComponentModel.ISupportInitialize)Foto).BeginInit();
            SuspendLayout();
            // 
            // Foto
            // 
            Foto.BackgroundImageLayout = ImageLayout.Stretch;
            Foto.Image = Properties.Resources.hVRJZhy0kS8;
            Foto.Location = new Point(25, 100);
            Foto.Name = "Foto";
            Foto.Size = new Size(170, 200);
            Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            Foto.TabIndex = 0;
            Foto.TabStop = false;
            // 
            // NamePerson
            // 
            NamePerson.AutoSize = true;
            NamePerson.BackColor = Color.Transparent;
            NamePerson.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NamePerson.Location = new Point(245, 32);
            NamePerson.Name = "NamePerson";
            NamePerson.Size = new Size(97, 41);
            NamePerson.TabIndex = 1;
            NamePerson.Text = "label1";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LastName.Location = new Point(217, 100);
            LastName.Name = "LastName";
            LastName.Size = new Size(97, 41);
            LastName.TabIndex = 2;
            LastName.Text = "label2";
            // 
            // DataName
            // 
            DataName.AutoSize = true;
            DataName.BackColor = Color.Transparent;
            DataName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataName.Location = new Point(199, 269);
            DataName.Name = "DataName";
            DataName.Size = new Size(74, 20);
            DataName.TabIndex = 3;
            DataName.Text = "Годен до:";
            // 
            // DatePasport
            // 
            DatePasport.AutoSize = true;
            DatePasport.BackColor = Color.Transparent;
            DatePasport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DatePasport.Location = new Point(279, 261);
            DatePasport.Name = "DatePasport";
            DatePasport.Size = new Size(54, 28);
            DatePasport.TabIndex = 4;
            DatePasport.Text = "Дата";
            // 
            // BornDate
            // 
            BornDate.AutoSize = true;
            BornDate.BackColor = Color.Transparent;
            BornDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BornDate.Location = new Point(356, 173);
            BornDate.Name = "BornDate";
            BornDate.Size = new Size(147, 28);
            BornDate.TabIndex = 5;
            BornDate.Text = "ДатаРождения";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.BackColor = Color.Transparent;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(199, 233);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(171, 28);
            IDLabel.TabIndex = 6;
            IDLabel.Text = "ID Кировчанина: ";
            // 
            // label1
            // 
            IDText.AutoSize = true;
            IDText.BackColor = Color.Transparent;
            IDText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDText.Location = new Point(376, 233);
            IDText.Name = "label1";
            IDText.Size = new Size(31, 28);
            IDText.TabIndex = 7;
            IDText.Text = "ID";
            // 
            // FormPasport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pasport;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(IDText);
            Controls.Add(IDLabel);
            Controls.Add(BornDate);
            Controls.Add(DatePasport);
            Controls.Add(DataName);
            Controls.Add(LastName);
            Controls.Add(NamePerson);
            Controls.Add(Foto);
            Name = "FormPasport";
            Size = new Size(595, 307);
            ((System.ComponentModel.ISupportInitialize)Foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Foto;
        private Label NamePerson;
        private Label LastName;
        private Label DataName;
        private Label DatePasport;
        private Label BornDate;
        private Label IDLabel;
        private Label IDText;
    }
}
