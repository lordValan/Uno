using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoProject
{
    public partial class ChooseCardForm : Form
    {
        public Int32 CardReturn { get; set; }
        private CardType TopCardType;
        private CardColors CurrentColor;
        private List<UnoCard> CardsList;

        public ChooseCardForm(List<UnoCard> list, CardType tp, CardColors cl)
        {
            InitializeComponent();
            Size ImgSize = Helper.CardSize;

            this.CardReturn = -1;
            this.CardsList = list;
            this.TopCardType = tp;
            this.CurrentColor = cl;

            for (int i = 0; i < this.CardsList.Count; i++)
            {
                Label tmpLb = new Label() { Left = i * (ImgSize.Width / 2), Image = this.CardsList[i].CurrentImage, Size = this.CardsList[i].CurrentImage.Size };
                this.playerPanel.Controls.Add(tmpLb);
                tmpLb.DoubleClick += tmpLb_DoubleClick;
                tmpLb.MouseMove += tmpLb_MouseMove;
                tmpLb.MouseLeave += tmpLb_MouseLeave;
            }

            this.FormClosing += ChooseCardForm_FormClosing;
        }

        void tmpLb_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BorderStyle = BorderStyle.None;
        }

        void tmpLb_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).BorderStyle = BorderStyle.FixedSingle;
        }

        private void ChooseCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in this.playerPanel.Controls)
            {
                ((Label)item).DoubleClick -= tmpLb_DoubleClick;
                ((Label)item).MouseMove -= tmpLb_MouseMove;
                ((Label)item).MouseLeave -= tmpLb_MouseLeave;
            }
        }

        private void tmpLb_DoubleClick(object sender, EventArgs e)
        {
            Int32 ind = this.playerPanel.Controls.IndexOf(sender as Label);
            UnoCard uno = this.CardsList[ind];

            if (TopCardType == CardType.ChooseColor || TopCardType == CardType.PlusFour)
            {
                if (uno.Color == CurrentColor || uno.Color == CardColors.Black)
                    CardReturn = ind;
                else
                    return;
            }
            else
            {
                if (uno.Color == CurrentColor || uno.Type == TopCardType || uno.Color == CardColors.Black)
                    CardReturn = ind;
                else
                    return;
            }

            this.Close();
        }

        private void btPass_Click(object sender, EventArgs e)
        {
            CardReturn = -1;
            this.Close();
        }
    }
}
