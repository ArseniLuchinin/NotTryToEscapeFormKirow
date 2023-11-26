using System.Windows.Forms;
using MultiPage;
using MainMenu;
using Rules;
using Generator;
using System.Net.Http.Headers;

namespace NotTryToEscapeFormKirow
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                formGame1.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MainMenu = new MainMenuPage(Controls);
            MainMenu.StartBtn.Click += StartGame;
            MainMenu.DescriptionBtn.Click += OpenDescription;
            MainMenu.OutBtn.Click += CloseGame;
            MainMenu.OpenEvent += OpenMainMenu;
            MainMenu.CloseEvent += CloseMainMenu;
            formGame1.MakeFullSkreen(this);

            DescriptionInicize();

            Rules = new RulesPage(Controls);
            Rules.OutBtn.Click += OutInMenu;

            MakeFullSkreen();

            MainMenu.Open();

        }
        private void MakeFullSkreen()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            label1.MaximumSize = label1.MinimumSize = label1.Size = new Size(Size.Width, 250);
        }

        private void openMenu(object sender, EventArgs e)
        {
            MainMenu.Open();
        }
        private void OpenDescription(object sender, EventArgs e)
        {
            MainMenu.Close();
            Description.Open();
        }

        private void StartGame(object sender, EventArgs e)
        {
            MainMenu.Close();
            formGame1.startGame();
            
        }
        private void CloseGame(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenMainMenu(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MainMenuBack;
        }
        private void CloseMainMenu(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
        }

        private void OutInMenu(object sender, EventArgs e)
        {
            if (Rules.isOpen)
            {
                Rules.Close();
                MainMenu.Open();
            }
        }
    }
}