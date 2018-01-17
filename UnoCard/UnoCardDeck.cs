using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoProject
{
    public class UnoCardDeck
    {
        // приватное поле класса
        private List<UnoCard> Cards = null;      // список всех карты, которые содержит в себе колода

        // публичное свойство класса
        public List<UnoCard> Deck { get { return this.Cards; } set { if(this.Cards.Count == 0) this.Cards = value; } }

        // конструктор класса
        public UnoCardDeck()
        {
            this.Cards = new List<UnoCard>();

            this.CreateDeck();      // создаем колоду из 108 карт
            this.SortDeck();        // сортируем её
        }

        // методы класса
        private void CreateDeck()
        {
            Int32 CardColorsAmount = Enum.GetValues(typeof(CardColors)).Length,     // количество возможных цветов карт
                CardsTypeAmount = Enum.GetValues(typeof(CardType)).Length,          // количество возможных типов карт
                ColourfullCardsAmount = CardsTypeAmount - 2,                        // количество цветных карт
                BlackCardsAmount = CardsTypeAmount - ColourfullCardsAmount;         // количество черных карт
            String FilePath = @"../../../Resources/SmallCards/", TempStr;           // путь к файлу с изображением

            for (int i = 0; i < CardColorsAmount; i++)      // цикл на то количество итераций, сколько всего цветов (5)
            {
                if (i == (Int32)CardColors.Black)           // если карта черная
                {
                    for (int t = 0; t < 2; t++)             // цикл для добавления черных карт (их всего две - плюс четыре и выбор цветаЦ)
                    {
                        TempStr = FilePath + ((CardColors)i).ToString() + "/0" + t.ToString() + ".jpg";     // задаем путь к необходимому изображению

                        for (int y = 0; y < 4; y++)     // цикл на 4 итерации, так как карт типа плюс четыре и выбор цвета в колоде должно находиться по 4 экземпляра
                            this.Cards.Add(new UnoCard((CardColors)i, ((CardType)ColourfullCardsAmount + t), 50, false, Image.FromFile(TempStr)));
                    }                    
                }
                else                                        // заполняем колоду цветными картами
                {
                    for (int j = 0; j < ColourfullCardsAmount; j++)     // цикл на то количество итераций, сколько всего типов кард, которые не черные (13)
                    {
                        TempStr = FilePath + ((CardColors)i).ToString() + ((j < 10) ? "/0" : "/") + j.ToString() + ".jpg";    // задаем путь к необходимому изображению

                        if (j == 0)     // если добавляем нулевую карту, то создаем только 4 экземпляра
                        {
                            this.Cards.Add(new UnoCard((CardColors)i, (CardType)j, j, false, Image.FromFile(TempStr)));
                        }
                        else
                        {
                            for (int q = 0; q < 2; q++)     // если добавляем не нудевую карту, то создаем её в количестве двух экземпляров
                            {
                                this.Cards.Add(new UnoCard((CardColors)i, (CardType)j, ((j < (Int32)CardType.Stop) ? j : 20),
                                    false, Image.FromFile(TempStr)));                                
                            }
                        }
                    }
                }
            }
        }

        public void SortDeck()         // сортировка колоды
        {
            UnoCard Tmp = null;
            Random R = new Random();
            int randNum1 = 0, randNum2 = 0;

            for (int i = 0; i < 200; i++)       // цикл на 200 итераций для перетасовки
            {
                randNum1 = R.Next(0, this.Cards.Count);
                randNum2 = R.Next(0, this.Cards.Count);

                Tmp = this.Cards[randNum1];
                this.Cards[randNum1] = this.Cards[randNum2];
                this.Cards[randNum2] = Tmp;
            }
        }
    }
}
