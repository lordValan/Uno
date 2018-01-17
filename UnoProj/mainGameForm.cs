using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnoProject;

namespace test
{
    public partial class mainGameForm : Form
    {
        static UnoSingleGame game;
        static List<Panel> panels;
        static List<Label> labels;
        Games gms;
        Int32 playersAm;

        public mainGameForm(Games gm, Int32 players)
        {
            InitializeComponent();
            panels = new List<Panel> { this.panelPlayerFirst, this.panelPlayerSecond, this.panelPlayerThird, this.panelPlayerFourth, this.panelPlayerFifth, this.panelPlayerSixth, this.panelMain };
            labels = new List<Label> { this.lbPlayerFirstName, this.lbPlayerSecond, this.lbPlayerThird, this.lbPlayerFourth, this.lbPlayerFifth, this.lbPlayerSixth, this.lbCurrentColor, this.lbCurrentCard };

            gms = gm;
            playersAm = players;
        }

        private async void StartGame()
        {
            await Task.Delay(game.PlayersAmount * 8 * 100);
            game.playersMove();
        }

        private void mainGameForm_Load(object sender, System.EventArgs e)
        {
            if (gms == Games.Local)
            {
                game = new UnoSingleGame(playersAm, panels, labels, "Danil");
                this.StartGame();
            }
        }
    }
}
