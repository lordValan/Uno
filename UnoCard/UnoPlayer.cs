using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UnoProject
{
    public class UnoUserPlayer
    {
        // приватные поля класса
        private String playerName = null;
        private List<UnoCard> playerCards = null;
        private Panel playerPanel = null;
        private Label playerLabel = null;

        // публичные свойства класса
        public String Name { get { return this.playerName; } }        
        public List<UnoCard> Cards { get { return this.playerCards; } }
        public UnoCard topCard { get; set; }
        public Panel PlayerPanel { get{ return this.playerPanel; } }
        public Label PlayerLabel { get { return this.playerLabel; } }
        
        public Int32 Points 
        { 
            get 
            {
                if (this.playerCards == null || this.playerCards.Count == 0)
                    return 0;

                Int32 tmp = 0;

                foreach (var item in this.playerCards)
                {
                    tmp += item.Points;
                }

                return tmp; 
            } 
        }

        // конструкторы класса
        public UnoUserPlayer(String name, Panel pan, Label lb)
        {
            Size tmpCardSize = Helper.CardSize;

            this.playerName = name;
            this.playerCards = new List<UnoCard>();
            this.topCard = null;

            pan.Visible = true;
            lb.Visible = true;
            lb.Text = this.Name;

            this.playerLabel = lb;
            this.playerPanel = pan;

            for (int i = 0; i < 30; i++)
            {
                Label tmpLb = new Label()
                        {
                            Text = String.Empty,
                            Left = i * (tmpCardSize.Width / 2),
                            Visible = false,
                            Size = tmpCardSize
                        };

                this.playerPanel.Controls.Add(tmpLb);
                tmpLb.MouseMove += tmpLb_MouseMove;
                tmpLb.MouseLeave += tmpLb_MouseLeave;
            }
        }

        // события, срабатываемые с элементами, принадлежащими классу
        void tmpLb_MouseLeave(object sender, EventArgs e)
        {
            Label tmp = sender as Label;
            tmp.BorderStyle = BorderStyle.None;
        }

        void tmpLb_MouseMove(object sender, MouseEventArgs e)
        {
            Label tmp = sender as Label;
            tmp.BorderStyle = BorderStyle.Fixed3D;
        }

        // методы класса

        public virtual void TakeCard(UnoCard card)      // виртуальный метод для добавления карты в список карт игрока 
        {
            Label currentLb;

            this.playerCards.Add(card);
            currentLb = this.playerPanel.Controls[this.playerCards.Count - 1] as Label;
            currentLb.Image = card.CurrentImage;
            currentLb.Visible = true;            
        }

        public void DeleteCard(UnoCard tmp)         // виртуальный метод для удаления карты из списка карт игрока 
        {
            Label tmpLbLeft, tmpLbRight;
            Int32 index = this.Cards.FindIndex(c => c == tmp);

            for (int i = index; i < this.Cards.Count; i++)
            {
                tmpLbLeft = this.playerPanel.Controls[i] as Label;
                tmpLbRight = this.playerPanel.Controls[i + 1] as Label;

                tmpLbLeft.Visible = tmpLbRight.Visible;
                tmpLbLeft.Image = tmpLbRight.Image;
            }

            this.playerCards.RemoveAt(index);
        }

        public virtual UnoCard Move(Label cr)       // виртуальный метод для осуществления хода игрока
        {
            ChooseCardForm form = null;
            UnoCard tmp;

            form = new ChooseCardForm(this.playerCards, topCard.Type, Helper.ToCardColor(cr.BackColor));
            form.ShowDialog();

            if (form.CardReturn != -1)
                tmp = this.Cards.ElementAt(form.CardReturn);
            else
                tmp = null;

            form.Dispose();
            return tmp;
        }

        public virtual CardColors ChooseColor()     // виртуальный метод для выбора цвета карты игроком
        {
            Color clr;
            ChooseColorForm frm = new ChooseColorForm();

            frm.ShowDialog();
            clr = frm.chosenColor;
            frm.Dispose();

            return Helper.ToCardColor(clr);
        }
    }
}
