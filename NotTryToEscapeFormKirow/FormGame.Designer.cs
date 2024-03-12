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
            NVCL = new FormNamedVCList();
            permission1 = new Permission();
            Score = new Label();
            mainVCL = new FormVaccinationList();
            Exit_bt = new Label();
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
            NVCL.BackgroundImage = (Image)resources.GetObject("vaccinationList1.BackgroundImage");
            NVCL.BackgroundImageLayout = ImageLayout.None;
            NVCL.Location = new Point(821, 206);
            NVCL.Name = "vaccinationList1";
            NVCL.Size = new Size(375, 533);
            NVCL.TabIndex = 1;
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
            // isValid
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.Transparent;
            Score.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            Score.ForeColor = Color.Black;
            Score.Location = new Point(878, 40);
            Score.Name = "isValid";
            Score.Size = new Size(189, 78);
            Score.TabIndex = 3;
            Score.Text = "label2";
            // 
            // formVaccinationList1
            // 
            mainVCL.BackgroundImage = (Image)resources.GetObject("formVaccinationList1.BackgroundImage");
            mainVCL.BackgroundImageLayout = ImageLayout.None;
            mainVCL.Location = new Point(1232, 174);
            mainVCL.Name = "formVaccinationList1";
            mainVCL.Size = new Size(377, 532);
            mainVCL.TabIndex = 4;
            // 
            // label2
            // 
            Exit_bt.AutoSize = true;
            Exit_bt.BackColor = Color.Transparent;
            Exit_bt.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Exit_bt.ForeColor = Color.Black;
            Exit_bt.Location = new Point(0, 0);
            Exit_bt.Name = "label2";
            Exit_bt.Size = new Size(133, 38);
            Exit_bt.TabIndex = 5;
            Exit_bt.Text = "Перекур";
            Exit_bt.Click += exitClick;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.BackgroundImage = Properties.Resources.Approved;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(3, 422);
            button1.Name = "Approved";
            button1.Size = new Size(357, 186);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += decideClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.BackgroundImage = Properties.Resources.Denied;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(3, 623);
            button2.Name = "Denied";
            button2.Size = new Size(357, 186);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            button2.Click += decideClick;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Table;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Exit_bt);
            Controls.Add(mainVCL);
            Controls.Add(Score);
            Controls.Add(permission1);
            Controls.Add(NVCL);
            Controls.Add(pasport1);
            Name = "FormGame";
            Size = new Size(1653, 926);
            Load += FormGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private FormPasport pasport1;
        private FormNamedVCList NVCL;
        private Permission permission1;
        private Label Score;
        private FormVaccinationList mainVCL;
        public Label Exit_bt { get; private set; }
        private Button button1;
        private Button button2;
    }
}
