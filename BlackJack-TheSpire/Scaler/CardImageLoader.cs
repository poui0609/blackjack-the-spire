using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJack_TheSpire.Scaler
{
    internal static class CardImageLoader
    {
        public static Image GetCardImage(Card card) //사진 가져오기
        {
            string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png"; //이름설정
            string path = Path.Combine(Application.StartupPath, "..", "..", "Resources", fileName); //경로설정
            path = Path.GetFullPath(path);
            return Image.FromFile(path);
        }
    }
}
