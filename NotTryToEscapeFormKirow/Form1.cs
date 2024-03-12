using System.Windows.Forms;
using MultiTask;
using System.Runtime.CompilerServices;

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
            player = new Player();
            startMenu1.player = player.asBuffer();
            startMenu1.StartBt.Click +=
                delegate (object? sender, EventArgs e) { formGame1.startGame(player); };
            startMenu1.ExitBt.Click +=
                delegate (object? sender, EventArgs e) 
                {
                    JSONSaver.saveRecords(JSONSaver.getRecords(player));
                    this.Close(); 
                };
            startMenu1.inputName.KeyPress += checkNewName;
            startMenu1.InstructionBt.Click += OpenDescription;

            instruction1.button1.Click += OutInMenu;
            formGame1.Exit_bt.Click += openMenu;

            MakeFullSkreen();
        }
        private void MakeFullSkreen()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            formGame1.MakeFullSkreen(this);
            startMenu1.MakeFullSkreen(this);
            instruction1.MakeFullSkreen(this);
        }
        private void checkNewName(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {   
                if(player.Name != startMenu1.newName){
                    player = new Player(startMenu1.newName);
                    startMenu1.player = player.asBuffer();
                }
            }
        }

        private void OpenDescription(object sender, EventArgs e)
        {
            startMenu1.Visible = false;
            instruction1.Visible = true;
        }
        private void openMenu(object sender, EventArgs e)
        {
            startMenu1.Visible = true;
            player.goodScore += formGame1.good;
            player.badScore += formGame1.bad;
            JSONSaver.saveRecords(JSONSaver.getRecords(player));
            startMenu1.setRecords();
            startMenu1.player = player.asBuffer();
        }

        private void OutInMenu(object sender, EventArgs e)
        {
            startMenu1.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            JSONSaver.SvaeLastPlayer(player);
        }
    }
}