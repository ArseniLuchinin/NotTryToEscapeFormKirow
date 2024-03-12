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
    partial class FormGame : UserControl
    {
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
        public int good { get; private set; }
        public int bad { get; private set; }
        private void setScore()
        {
            Score.Text = $"Правильно: {good} Ошибочно: {bad}";
            Score.Location = new Point(
                this.Width - Score.Width - 10,
                10
                );
        }

        private void exitClick(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        Game game;
        public void startGame(Player player)
        {
            game = new Game();
            good = 0; bad = 0;
            updateMainVCL(game.VCL);
            setDocuments(game.Next());
            setScore();
            this.Visible = true;
        }
        private void setDocuments(Visitor v)
        {
            pasport1.SetPasport(v.pasport);
            NVCL.setInfo(v.NVCL);
            permission1.setInfo(v.permission);
        }
        private void decideClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            updateScore(bt);
            setDocuments(game.Next());
            updateMainVCL(game.VCL);
        }
        private void updateMainVCL(VaccinationList newVcl)
        {
            if(newVcl != null)
                mainVCL.setVCList(newVcl);
        }

        private void updateScore(Button bt)
        {
            bool isValidDocuments = game.getDataValidation();
            if (isValidDocuments && (bt.Name == "Approved"))
                good++;
            else if (!isValidDocuments && (bt.Name == "Denied"))
                good++;
            else
                bad++;

            setScore();
        }
    }
}
