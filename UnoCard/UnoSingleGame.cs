using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoProject
{
    public enum Side { Back, Front };

    public class UnoSingleGame
    {
        static String[] NamesUsers = new String[5] { "Ann", "Joe", "Theo", "Jessica", "Andrew" };
        static Random R = new Random();

        private UnoCardDeck mainDeck;
        private List<UnoCard> outage;
        private List<UnoUserPlayer> players;
        private Int32 playersAmount, activePlayer;
        private Panel mainPanel;
        private Side side;
        private Label lbCurrentColor, lbTopCard;

        public UnoCardDeck GameDeck { get { return this.mainDeck; } }
        public Int32 PlayersAmount { get { return this.playersAmount; } }

        public UnoSingleGame(Int32 PlayersAmount, List<Panel> playersPanel, List<Label> playersLabels, String mainUserName)
        {
            if (PlayersAmount < 2)
                this.playersAmount = 2;
            else
            {
                if (PlayersAmount > 6)
                    this.playersAmount = 6;
                else
                    this.playersAmount = PlayersAmount;
            }

            this.players = new List<UnoUserPlayer>();

            for (int i = 0; i < this.playersAmount; i++)
            {
                if (i == 0)
                    this.players.Add(new UnoUserPlayer(mainUserName, playersPanel[i], playersLabels[i]));
                else
                    this.players.Add(new UnoComputerPlayer(NamesUsers[R.Next(0, NamesUsers.Length)], playersPanel[i], playersLabels[i]));

                playersPanel[i].Visible = true;
                playersLabels[i].Visible = true;
            }

            this.side = Side.Front;

            this.mainPanel = playersPanel[playersPanel.Count - 1];
            this.lbCurrentColor = playersLabels[playersLabels.Count - 2];
            this.lbTopCard = playersLabels[playersLabels.Count - 1];

            this.mainDeck = new UnoCardDeck();
            this.outage = new List<UnoCard>();

            this.FillPanels();

            UnoCard tmp = this.mainDeck.Deck.First();
            this.mainDeck.Deck.RemoveAt(0);

            this.lbTopCard.Image = tmp.CurrentImage;

            foreach (var item in this.players)
            {
                item.topCard = tmp;
            }

            this.setColor(tmp.Color);
            this.activePlayer = 0;
        }

        private void PlayerMove(UnoCard playerCard)
        {
            this.outage.Add(playerCard);

            if (mainDeck.Deck.Count == 0)
            {
                mainDeck.Deck = outage;
                mainDeck.SortDeck();
                outage.Clear();
            }

            foreach (var item in this.players)
            {
                item.topCard = playerCard;
            }

            if (playerCard.Type != CardType.PlusTwo && playerCard.Type != CardType.Reverse && playerCard.Type != CardType.Stop && playerCard.Color != CardColors.Black)
            {
                this.setColor(playerCard.Color);
                changePlayer();
            }
            else
            {
                if (playerCard.Color == CardColors.Black)
                {
                    if (playerCard.Type == CardType.PlusFour)
                    {
                        this.setColor(this.players[this.activePlayer].ChooseColor());
                        this.changePlayer();
                        for (int i = 0; i < 4; i++)
                        {
                            this.players[activePlayer].TakeCard(this.mainDeck.Deck.First());
                            mainDeck.Deck.RemoveAt(0);
                        }
                        this.changePlayer();
                    }
                    else
                    {
                        this.setColor(this.players[this.activePlayer].ChooseColor());
                        changePlayer();
                    }
                }
                else
                    this.setColor(playerCard.Color);


                if (playerCard.Type == CardType.PlusTwo)
                {
                    changePlayer();
                    for (int w = 0; w < 2; w++)
                    {
                        this.players[activePlayer].TakeCard(this.mainDeck.Deck.First());
                        mainDeck.Deck.RemoveAt(0);
                    }
                    changePlayer();
                }

                if (playerCard.Type == CardType.Reverse)
                {
                    if (this.side == Side.Front)
                        this.side = Side.Back;
                    else
                        this.side = Side.Front;
                    changePlayer();
                }

                if (playerCard.Type == CardType.Stop)
                {
                    for (int w = 0; w < 2; w++)                    
                        this.changePlayer();
                }
            }
        }

        private async void FillPanels()
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < this.playersAmount; i++)
                {
                    UnoCard tmp = this.mainDeck.Deck.ElementAt(0);

                    if (i != 0)
                        tmp.IsHidden = true;

                    this.players[i].TakeCard(tmp);
                    this.mainDeck.Deck.RemoveAt(0);
                    await Task.Delay(100);
                }
            }
        }

        public async void playersMove()
        {            
            Boolean countCards = false;
            Int32 currLastPlayer;

            while (!countCards)
            {
                currLastPlayer = this.activePlayer;
                this.players[currLastPlayer].PlayerLabel.Font = new System.Drawing.Font("Modern No. 20", 16);

                if(this.activePlayer != 0)
                    await Task.Delay(R.Next(1000, 3000));

                UnoCard tmp = this.players[this.activePlayer].Move(this.lbCurrentColor);
                Console.WriteLine(players[activePlayer].Name + " " + (tmp == null ? "null" : tmp.ToString()));
                if (tmp != null)
                {
                    tmp.IsHidden = false;
                    players[activePlayer].DeleteCard(tmp);
                    this.PlayerMove(tmp);
                    this.lbTopCard.Image = tmp.CurrentImage;
                }
                else
                {
                    this.players[activePlayer].TakeCard(this.mainDeck.Deck.First());
                    mainDeck.Deck.RemoveAt(0);                
                    this.changePlayer();
                }               
                
                countCards = players.Where(c => c.Cards.Count == 0).Count() > 0;
                this.players[currLastPlayer].PlayerLabel.Font = new System.Drawing.Font("Modern No. 20", 11);
            }

            StringBuilder strB = new StringBuilder();

            foreach (var item in players.Where(c => c.Cards.Count != 0).ToArray())
            {
                strB.Append(item.Name + " " + item.Points.ToString() + ";\n");
                
                if(item.GetType() == typeof(UnoComputerPlayer))
                {
                    for (int i = 0; i < item.Cards.Count; i++)
			        {
			            item.Cards[i].IsHidden = false;
                        ((Label)item.PlayerPanel.Controls[i]).Image = item.Cards[i].CurrentImage;
			        }
                }
            }

            MessageBox.Show(strB.ToString());
            Application.Exit();
        }

        private void changePlayer()
        {
            if (this.side == Side.Front)
            {
                activePlayer++;
                if (activePlayer == playersAmount)
                    activePlayer = 0;
            }
            else
            {
                activePlayer--;
                if (activePlayer == -1)
                    activePlayer = this.playersAmount - 1;
            }
        }

        private void setColor(CardColors clr)
        {
            this.lbCurrentColor.BackColor = Helper.ToColor(clr);
        }
    }   
}
