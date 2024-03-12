namespace NotTryToEscapeFormKirow
{
    partial class StartMenu
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
            pictureBox1 = new PictureBox();
            StartBt = new Button();
            InstructionBt = new Button();
            ExitBt = new Button();
            label1 = new Label();
            Scor = new Label();
            PlayerName = new Label();
            inputName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.MainMenuKirow;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1326, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 449);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StartBt
            // 
            StartBt.BackColor = Color.Maroon;
            StartBt.FlatStyle = FlatStyle.Popup;
            StartBt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            StartBt.Location = new Point(267, 554);
            StartBt.Name = "StartBt";
            StartBt.Size = new Size(546, 102);
            StartBt.TabIndex = 1;
            StartBt.TabStop = false;
            StartBt.Text = "Бесконечная смена ";
            StartBt.UseVisualStyleBackColor = false;
            StartBt.Click += closeMenu;
            // 
            // InstructionBt
            // 
            InstructionBt.BackColor = Color.Maroon;
            InstructionBt.FlatStyle = FlatStyle.Popup;
            InstructionBt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            InstructionBt.Location = new Point(267, 684);
            InstructionBt.Name = "InstructionBt";
            InstructionBt.Size = new Size(546, 95);
            InstructionBt.TabIndex = 2;
            InstructionBt.TabStop = false;
            InstructionBt.Text = "Инструктаж";
            InstructionBt.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            ExitBt.BackColor = Color.Maroon;
            ExitBt.FlatStyle = FlatStyle.Popup;
            ExitBt.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ExitBt.Location = new Point(267, 812);
            ExitBt.Name = "Exit";
            ExitBt.Size = new Size(546, 95);
            ExitBt.TabIndex = 3;
            ExitBt.TabStop = false;
            ExitBt.Text = "Сбежать из Кирова";
            ExitBt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 64.2000046F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(1304, 290);
            label1.TabIndex = 4;
            label1.Text = "Не пытайтесь покинуть\nКиров";
            // 
            // Scor
            // 
            Scor.AutoSize = true;
            Scor.BackColor = Color.Transparent;
            Scor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Scor.ForeColor = Color.White;
            Scor.Location = new Point(1729, 50);
            Scor.Name = "Scor";
            Scor.Size = new Size(88, 38);
            Scor.TabIndex = 10;
            Scor.Text = "(счёт)";
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.BackColor = Color.Transparent;
            PlayerName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerName.ForeColor = Color.White;
            PlayerName.Location = new Point(1729, 0);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(191, 41);
            PlayerName.TabIndex = 9;
            PlayerName.Text = "Имя игрока";
            PlayerName.Click += PlayerName_Click;
            // 
            // inputName
            // 
            inputName.BackColor = Color.Maroon;
            inputName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            inputName.ForeColor = Color.White;
            inputName.Location = new Point(1729, 3);
            inputName.Name = "inputName";
            inputName.Size = new Size(191, 47);
            inputName.TabIndex = 11;
            inputName.KeyPress += inputName_KeyPress;
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainMenuBack;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(inputName);
            Controls.Add(Scor);
            Controls.Add(PlayerName);
            Controls.Add(label1);
            Controls.Add(ExitBt);
            Controls.Add(InstructionBt);
            Controls.Add(StartBt);
            Controls.Add(pictureBox1);
            Name = "StartMenu";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Button StartBt { get; private set; }
        public Button InstructionBt { get; private set; }
        public Button ExitBt { get; private set; }
        private Label label1;
        private Label Scor;
        private Label PlayerName;
        public TextBox inputName { get; private set; }
    }
}
