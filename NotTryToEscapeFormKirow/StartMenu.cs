using MultiTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotTryToEscapeFormKirow
{

    partial class StartMenu : UserControl
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void PlayerName_Click(object sender, EventArgs e)
        {
            PlayerName.Visible = false;
            inputName.Visible = true;
            Scor.Visible = false;
            inputName.Text = "";
        }

        private PlayerBuffer _player;
        public PlayerBuffer player
        {
            set
            {
                _player = value;
                setName();
            }
        }
        public String newName { get; private set; }
        private void inputName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (WinFormInstruments.enterName(inputName.Text))
                {
                    e.Handled = true;
                    newName = inputName.Text;
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
                setName();
            }
        }
        private void setName()
        {
            PlayerName.Text = _player.Name;
            Scor.Text = _player.goodScore.ToString() + " / " + _player.badScore.ToString();
            inputName.Visible = false;
            Scor.Visible = true;
            PlayerName.Visible = true;
        }
        public void MakeFullSkreen(Form f)
        {
            this.Size = f.Size;
            StartMenu_Load(this, new EventArgs());
        }
        private void closeMenu(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        Label records = new Label();
        private void StartMenu_Load(object sender, EventArgs e)
        {   
            records.Location = new Point(Scor.Location.X - 50, Scor.Location.Y + 40);
            records.MinimumSize = records.MinimumSize = new Size(260, 500);
            records.Font = new Font(records.Font.Name, 18, FontStyle.Bold);
            records.ForeColor = Color.White;
            records.BackColor = Color.Transparent;
            Controls.Add(records);
            setRecords();
        }

        public void setRecords()
        {
            records.Text = "Рекоры:\n";
            foreach (var item in JSONSaver.getRecords())
            {
                records.Text += $"{item.Name}: {item.goodScore}/{item.badScore}\n";
            }
        }
    }
}
