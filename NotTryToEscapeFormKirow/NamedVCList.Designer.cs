namespace NotTryToEscapeFormKirow
{
    partial class FormNamedVCList
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

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            label2 = new Label();
            FormName = new Label();
            BornDate = new Label();
            BornDateLabel = new Label();
            Date = new Label();
            label7 = new Label();
            FormLastName = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "ФИО:";
            // 
            // label3
            // 
            FormName.AutoSize = true;
            FormName.BackColor = Color.Transparent;
            FormName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormName.Location = new Point(61, 0);
            FormName.Name = "label3";
            FormName.Size = new Size(100, 28);
            FormName.TabIndex = 12;
            FormName.Text = "(ВашеИмя)";
            // 
            // labelLN
            // 
            FormLastName.AutoSize = true;
            FormLastName.BackColor = Color.Transparent;
            FormLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormLastName.Location = new Point(FormName.Size.Width, 0);
            FormLastName.Name = "label3";
            FormLastName.Size = new Size(100, 28);
            FormLastName.TabIndex = 12;
            FormLastName.Text = "(ВашеИмя)";
            // 
            // label4
            // 
            BornDate.AutoSize = true;
            BornDate.BackColor = Color.Transparent;
            BornDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BornDate.Location = new Point(3, 28);
            BornDate.Name = "label4";
            BornDate.Size = new Size(84, 28);
            BornDate.TabIndex = 4;
            BornDate.Text = "(дата рождения)";
            // 
            // label5
            // 
            BornDateLabel.AutoSize = true;
            BornDateLabel.BackColor = Color.Transparent;
            BornDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BornDateLabel.Location = new Point(0, 28);
            BornDateLabel.Name = "label5";
            BornDateLabel.Size = new Size(168, 28);
            BornDateLabel.TabIndex = 3;
            BornDateLabel.Text = "Года рождения";
            // 
            // label6
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.Transparent;
            Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Date.Location = new Point(107, 475);
            Date.Name = "label6";
            Date.Size = new Size(66, 28);
            Date.TabIndex = 6;
            Date.Text = "(Дата)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 475);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 5;
            label7.Text = "Годен до:";
            // 
            // NamedVCList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Date);
            Controls.Add(label7);
            Controls.Add(BornDate);
            Controls.Add(BornDateLabel);
            Controls.Add(FormName);
            Controls.Add(FormLastName);
            Controls.Add(label2);
            base.Name = "NamedVCList";
            Size = new Size(375, 531);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(FormName, 0);
            Controls.SetChildIndex(BornDateLabel, 0);
            Controls.SetChildIndex(BornDate, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(Date, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label FormName;
        private Label FormLastName;
        private Label BornDate;
        private Label BornDateLabel;
        private Label Date;
        private Label label7;
    }
}
