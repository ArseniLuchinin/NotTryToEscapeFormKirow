using System.Windows.Forms;
using Generator;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pasport1 = new FormPasport();
            vaccinationList1 = new FormVaccinationList();
            SuspendLayout();
            // 
            // pasport1
            // 
            pasport1.BackgroundImage = (Image)resources.GetObject("pasport1.BackgroundImage");
            pasport1.BackgroundImageLayout = ImageLayout.None;
            pasport1.Location = new Point(69, 12);
            pasport1.Name = "pasport1";
            pasport1.Size = new Size(1026, 522);
            pasport1.TabIndex = 0;
            pasport1.Load += pasport1_Load;
            // 
            // vaccinationList1
            // 
            vaccinationList1.BackgroundImage = (Image)resources.GetObject("vaccinationList1.BackgroundImage");
            vaccinationList1.BackgroundImageLayout = ImageLayout.None;
            vaccinationList1.Location = new Point(1145, 50);
            vaccinationList1.Name = "vaccinationList1";
            vaccinationList1.Size = new Size(375, 533);
            vaccinationList1.TabIndex = 1;
            vaccinationList1.Load += vaccinationList1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(vaccinationList1);
            Controls.Add(pasport1);
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
        private FormPasport pasport1;
        private FormVaccinationList vaccinationList1;
    }
}