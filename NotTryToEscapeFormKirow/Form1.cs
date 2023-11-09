using System.Windows.Forms;

namespace NotTryToEscapeFormKirow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeFullSkreen();
            MainMenuInicize();
            MainMenu = new Page(
                button1,
                button2,
                button3,
                GameName,
                pictureBox1
                );
            MainMenu.OpenEvent += OpenMainMenu;
            MainMenu.CloseEvent += CloseMainMenu;

            Description = new Page(
                label1
                );
            Description.OpenEvent += OpenDiscription;

            MainMenu.Open();

        }
        private void MakeFullSkreen()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            label1.MaximumSize = label1.MinimumSize = label1.Size = new Size(Size.Width, 250);
        }
        private void OpenDiscription(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Dis;
            label1.Text = DesFile[0];
        }

        private void OpenMainMenu(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.MainMenuBack;
        }
        private void CloseMainMenu(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Window;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu.Close();
            Description.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu.Close();
        }
        String[] DesFile = Properties.Resources.gameDescription.Split('\n');
        int ClickIndex = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Description_Click(object sender, EventArgs e)
        {
            if (++ClickIndex >= DesFile.Length)
                outputRules();
            else label1.Text = DesFile[ClickIndex];
        }
        private void outputRules()
        {

        }
    }
}