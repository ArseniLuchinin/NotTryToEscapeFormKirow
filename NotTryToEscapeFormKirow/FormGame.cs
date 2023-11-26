using Generator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NotTryToEscapeFormKirow
{
    public partial class FormGame : UserControl
    {
        PasportMissGenerator pmg = new PasportMissGenerator();
        MissNVCLGenerator vmg = new MissNVCLGenerator();
        PermissionMissGenerator pemg = new PermissionMissGenerator();
        Random r = new Random();
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            this.Visible = false;

        }


        public void MakeFullSkreen(Form f)
        {
            this.Size = f.Size;
        }
        int good, bad;
        public void startGame()
        {

            good = 0; bad = 0;
            Next();
            setScore();
            this.Visible = true;
        }
        private void setScore()
        {
            Score.Text = $"Правильно: {good} Ошибочно: {bad}";
            Score.Location = new Point(
                this.Width - Score.Width - 10,
                10
                );
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        VaccinationList mainVCL;
        int mainVCLItreration = 0;
        Pasport pasport;
        NamedVaccinationList NVCL;
        OriginalPermission orgPre;
        GameValidator game;
        private void Next()
        {
            mainVCL = new randomVCList();
            formVaccinationList1.setVCList(mainVCL);

            pasport = new PasportGenerator();
            NVCL = new NamedVaccinationList(pasport, mainVCL, DateOnly.FromDateTime(DateTime.Now));
            orgPre = new OriginalPermission(pasport);

            miss();

            pasport1.SetPasport(pasport);
            vaccinationList1.setInfo(NVCL);
            permission1.setInfo(orgPre);

            game = new GameValidator(pasport, NVCL, mainVCL, orgPre);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (game.getDataValidation() && (bt.Name == "Approved"))
                good++;
            else if (!game.getDataValidation() && (bt.Name == "Denied"))
                good++;
            else bad++;
            setScore();
            Next();
        }

        private void miss()
        {
            int shans = 100;
            if (r.Next(0, shans) > shans / 2)
                generateMiss();
        }

        private void generateMiss()
        {
            int len = r.Next(1, 3);
            for (int i = 0; i < len; i++)
            {
                switch (r.Next(0, 3))
                {
                    case 0:
                        pmg.GenerateMiss(ref pasport);
                        break;
                    case 1:
                        vmg.GenerateMiss(ref NVCL);
                        break;
                    case 2:
                        pemg.GenerateMiss(ref orgPre);
                        break;
                }

            }

        }
    }
}
