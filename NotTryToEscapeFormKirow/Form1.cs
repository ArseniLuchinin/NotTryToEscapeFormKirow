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
            MainMenu = new Page(
                this,
                SystemColors.ControlText, 
                button1, 
                button2, 
                button3, 
                richTextBox1, 
                pictureBox1
                );
            MainMenu.Open();
        }
        private void MainMenuInicize()
        {
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
        }
        private void MakeFullSkreen()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}