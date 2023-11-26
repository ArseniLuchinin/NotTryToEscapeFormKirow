namespace NotTryToEscapeFormKirow
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            pasport1 = new FormPasport();
            vaccinationList1 = new FormNamedVCList();
            permission1 = new Permission();
            Score = new Label();
            formVaccinationList1 = new FormVaccinationList();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // pasport1
            // 
            pasport1.BackgroundImage = (Image)resources.GetObject("pasport1.BackgroundImage");
            pasport1.BackgroundImageLayout = ImageLayout.None;
            pasport1.Location = new Point(215, 66);
            pasport1.Name = "pasport1";
            pasport1.Size = new Size(600, 308);
            pasport1.TabIndex = 0;
            // 
            // vaccinationList1
            // 
            vaccinationList1.BackgroundImage = (Image)resources.GetObject("vaccinationList1.BackgroundImage");
            vaccinationList1.BackgroundImageLayout = ImageLayout.None;
            vaccinationList1.Location = new Point(821, 206);
            vaccinationList1.Name = "vaccinationList1";
            vaccinationList1.Size = new Size(375, 533);
            vaccinationList1.TabIndex = 1;
            // 
            // permission1
            // 
            permission1.BackgroundImage = (Image)resources.GetObject("permission1.BackgroundImage");
            permission1.BackgroundImageLayout = ImageLayout.None;
            permission1.Location = new Point(470, 408);
            permission1.Name = "permission1";
            permission1.Size = new Size(300, 200);
            permission1.TabIndex = 2;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            Score.ForeColor = Color.Black;
            Score.Location = new Point(878, 40);
            Score.Name = "Score";
            Score.Size = new Size(189, 78);
            Score.TabIndex = 3;
            Score.Text = "label2";
            // 
            // formVaccinationList1
            // 
            formVaccinationList1.BackgroundImage = (Image)resources.GetObject("formVaccinationList1.BackgroundImage");
            formVaccinationList1.BackgroundImageLayout = ImageLayout.None;
            formVaccinationList1.Location = new Point(1232, 174);
            formVaccinationList1.Name = "formVaccinationList1";
            formVaccinationList1.Size = new Size(377, 532);
            formVaccinationList1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.BackgroundImage = Properties.Resources.Approved;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(3, 422);
            button1.Name = "button1";
            button1.Size = new Size(357, 186);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.BackgroundImage = Properties.Resources.Denied;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(3, 623);
            button2.Name = "button2";
            button2.Size = new Size(357, 186);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Table;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(formVaccinationList1);
            Controls.Add(Score);
            Controls.Add(permission1);
            Controls.Add(vaccinationList1);
            Controls.Add(pasport1);
            Name = "FormGame";
            Size = new Size(1653, 926);
            Load += FormGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FormPasport pasport1;
        private FormNamedVCList vaccinationList1;
        private Permission permission1;
        private Label Score;
        private FormVaccinationList formVaccinationList1;
        public Label label2 { get; private set; }
        private Button button1;
        private Button button2;
    }
}
