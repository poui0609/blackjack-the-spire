using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_TheSpire
{
    public partial class DeckCount : Form
    {
        private GameState gameState;
        internal DeckCount(GameState gameState)
        {
            InitializeComponent();

            this.gameState = gameState;

            ShowDeck();
        }
        private void ShowDeck()
        {
            List<Card> cards =
                gameState.GetDeck().GetAllCards();

            cards.Sort((a, b) =>
            {
                int typeCompare =
                    a.GetCardType().CompareTo(b.GetCardType());

                if (typeCompare != 0)
                    return typeCompare;

                return a.GetMissionValue()
                    .CompareTo(b.GetMissionValue());
            });

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();

            foreach (Card card in cards)
            {
                Panel targetPanel =
                    GetPanelByCardType(card.GetCardType());

                PictureBox pb = new PictureBox();

                pb.Size = new Size(73, 101);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = GetCardImage(card);

                int index = targetPanel.Controls.Count;

                pb.Location = new Point(index * 30, 10);

                targetPanel.Controls.Add(pb);

                pb.BringToFront();
            }
        }
        private Panel GetPanelByCardType(CardType type)
        {
            switch (type)
            {
                case CardType.Spade:
                    return panel1;

                case CardType.Club:
                    return panel2;

                case CardType.Diamond:
                    return panel3;

                case CardType.Heart:
                    return panel4;

                default:
                    return panel1;
            }
        }
        Image GetCardImage(Card card)
        {
            string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png";

            string path =
                Path.Combine(
                    Application.StartupPath,
                    "..",
                    "..",
                    "Resources",
                    fileName);

            path = Path.GetFullPath(path);

            return Image.FromFile(path);
        }
    }
}
