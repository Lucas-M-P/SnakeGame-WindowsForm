using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();

            if (EasyRadioButton.Checked)
            {
                formGame.timerMiliSeconds = 300;
            }
            else if (MidiumRadioButton.Checked)
            {
                formGame.timerMiliSeconds = 100;
            }
            else if (HardRadioButton.Checked)
            {
                formGame.timerMiliSeconds = 65;
            }

            formGame.Show();
        }

        private void FormMenu_Shown(object sender, EventArgs e)
        {
            MidiumRadioButton.Checked = true;
        }
    }
}
