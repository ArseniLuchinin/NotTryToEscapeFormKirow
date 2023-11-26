namespace NotTryToEscapeFormKirow
{
    partial class Permission
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
            KName = new Label();
            LName = new Label();
            LnameIa = new Label();
            NameIa = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Id = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // KName
            // 
            KName.AutoSize = true;
            KName.BackColor = Color.Transparent;
            KName.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            KName.Location = new Point(89, 0);
            KName.Name = "KName";
            KName.Size = new Size(51, 21);
            KName.TabIndex = 0;
            KName.Text = "(Имя)";
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.BackColor = Color.Transparent;
            LName.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            LName.Location = new Point(149, 0);
            LName.Name = "LName";
            LName.Size = new Size(88, 21);
            LName.TabIndex = 1;
            LName.Text = "(Фамилия)";
            // 
            // LnameIa
            // 
            LnameIa.AutoSize = true;
            LnameIa.BackColor = Color.Transparent;
            LnameIa.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            LnameIa.Location = new Point(74, 176);
            LnameIa.Name = "LnameIa";
            LnameIa.Size = new Size(97, 21);
            LnameIa.TabIndex = 3;
            LnameIa.Text = "(ФамилияЯ)";
            // 
            // NameIa
            // 
            NameIa.AutoSize = true;
            NameIa.BackColor = Color.Transparent;
            NameIa.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            NameIa.Location = new Point(8, 176);
            NameIa.Name = "NameIa";
            NameIa.Size = new Size(60, 21);
            NameIa.TabIndex = 2;
            NameIa.Text = "(ИмяЯ)";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(163, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 132);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(0, 65);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "ID Кировчанина: ";
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.BackColor = Color.Transparent;
            Id.Location = new Point(136, 65);
            Id.Name = "Id";
            Id.Size = new Size(34, 20);
            Id.TabIndex = 6;
            Id.Text = "(ID)";
            // 
            // Permission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DocumentToLiveFromKirow;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(Id);
            Controls.Add(label1);
            Controls.Add(LnameIa);
            Controls.Add(NameIa);
            Controls.Add(LName);
            Controls.Add(KName);
            Controls.Add(pictureBox1);
            Name = "Permission";
            Size = new Size(295, 200);
            Load += Permission_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KName;
        private Label LName;
        private Label LnameIa;
        private Label NameIa;
        private PictureBox pictureBox1;
        private Label label1;
        private Label Id;
    }
}
