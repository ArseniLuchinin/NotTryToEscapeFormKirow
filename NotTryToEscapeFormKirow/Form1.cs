using System.Windows.Forms;

namespace NotTryToEscapeFormKirow
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainMenuInicize();
            DescriptionInicize();
            RulesIniciaze();



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


    }
}