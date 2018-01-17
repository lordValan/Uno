using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public enum Games { Local, WithFriends }

    public partial class UnoGameMainWindowDialog : Form
    {
        public UnoGameMainWindowDialog()
        {
            InitializeComponent();            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNewLocalGame_Click(object sender, EventArgs e)
        {            
            PlayersAmountForm playersForm = new PlayersAmountForm();
            if (playersForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mainGameForm gameForm = new mainGameForm(Games.Local, Convert.ToInt32(playersForm.mainNUD.Value));
                gameForm.ShowDialog();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btNewNetGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NewGameWithFriends");
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Statistics");
        }
    }
}
