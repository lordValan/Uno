using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoProject
{
    public enum CardColors      // перечисление со всеми возможными цветами карты
    {
        Red, Green, Yellow, Blue, Black
    };

    public enum CardType        // перечисление со всеми возможными типами карты
    {
        Zero, One, Two, Three, Four, Five, Six, Seven, Eight,
        Nine, Stop, Reverse, PlusTwo, PlusFour, ChooseColor
    };

    public class UnoCard
    {
        // приватные поля класса
        private Image hiddenImage = null, mainImage = null;       // изображения карты (скрытое/открытое)
        private CardColors cardColor;               // цвет карты
        private CardType cardType;                  // тип карты
        private Int32 cardPoints = 0;               // количество очков карты
        private Boolean cardStatus = false;         // статус карты (скрыта/открыта)

        // публичные свойства класса
        public CardColors Color { get { return this.cardColor; } }
        public CardType Type { get { return this.cardType; } }
        public Int32 Points { get { return this.cardPoints; } }
        public Boolean IsHidden { get { return this.cardStatus; } set { this.cardStatus = value; } }
        public Image CurrentImage { get { return this.cardStatus ? this.hiddenImage : this.mainImage; } }

        // конструкторы класса
        public UnoCard() { }

        public UnoCard(CardColors cl, CardType ct, Int32 pt, Boolean isHid, Image img)
        {
            this.cardColor = cl;        // присваиваем цвет карте
            this.cardType = ct;         // присваиваем тип карте
            this.cardPoints = pt;       // присваиваем очки карте
            this.cardStatus = isHid;    // присваиваем статус карте
            this.hiddenImage = Image.FromFile(@"../../../Resources/SmallCards/Black/02.jpg");    // присваиваем карте её скрытое изображение
            this.mainImage = img;       // // присваиваем карте её открытое изображение
        }

        // методы класса
        public UnoCard Clone()      // метод, который создает клон нашей карты
        {
            return new UnoCard(this.Color, this.Type, this.Points, this.IsHidden, this.mainImage);
        }

        public override string ToString()       // перегруженный метод ToString()
        {
            return String.Format("{0}, {1}, points: {2}", this.Type.ToString(), this.Color.ToString(), this.Points.ToString());
        }
    }
}

