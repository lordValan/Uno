using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoProject
{
    public class UnoComputerPlayer : UnoUserPlayer
    {
        public UnoComputerPlayer(String PlayerName, Panel pan, Label lb)
            : base(PlayerName, pan, lb) { }

        public override UnoCard Move(Label currentColor)
        {
            UnoCard crd = this.topCard;
            CardColors colorTmp = crd.Color;

            if (crd.Color == CardColors.Black)
                colorTmp = Helper.ToCardColor(currentColor.BackColor);
            
            var colorsCards = this.Cards.Where(c => c.Color == colorTmp);

            if (colorsCards.Count() > 0)
                return colorsCards.First();

            var typeCards = this.Cards.Where(t => t.Type == crd.Type);

            if (typeCards.Count() > 0)
                return typeCards.First();

            var blackCards = this.Cards.Where(t => t.Color == CardColors.Black);

            if (blackCards.Count() > 0)
                return blackCards.First();

            return null;
        }

        public override void TakeCard(UnoCard card)
        {
            card.IsHidden = true;
            base.TakeCard(card);
        }

        public override CardColors ChooseColor()
        {
            return this.Cards.First().Color;
        }
    }
}
