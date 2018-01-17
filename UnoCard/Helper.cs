using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UnoProject
{
    public class Helper     // вспомогательный класс со статическими методами
    {
        public static Size CardSize { get { return Image.FromFile(@"../../../Resources/SmallCards/Black/02.jpg").Size; } }

        public static Color ToColor(CardColors Clr)       // конвертер цвета из CardColors в Color из пространства имен System.Drawing
        {
            switch (Clr)
            {
                case CardColors.Red:
                    return Color.Red;
                case CardColors.Yellow:
                    return Color.Yellow;
                case CardColors.Blue:
                    return Color.Blue;
                case CardColors.Green:
                    return Color.Green;
            }

            return Color.Red;
        }

        public static CardColors ToCardColor(Color Clr)   // конвертер цвета из Color из пространства имен System.Drawing в CardColors
        {
            switch (Clr.Name)
            {
                case "Red":
                    return CardColors.Red;
                case "Yellow":
                    return CardColors.Yellow ;
                case "Blue":
                    return CardColors.Blue;
                case "Green":
                    return CardColors.Green;
            }

            return CardColors.Red;
        }

    }
}
