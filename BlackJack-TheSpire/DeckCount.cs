using BlackJack_TheSpire.Scaler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BlackJack_TheSpire
{
    public partial class DeckCount : Form
    {
        private GameState gameState;
        private FormScaler scaler;

        // 실행 중 생성되는 카드 PictureBox 기준값
        private const int CARD_BASE_WIDTH = 73;
        private const int CARD_BASE_HEIGHT = 101;
        private const int CARD_GAP = 30;
        private const int CARD_MARGIN_Y = 10;

        internal DeckCount(GameState gameState)
        {
            InitializeComponent();

            scaler = new FormScaler(this);

            this.gameState = gameState;

            ShowDeck();
        }

        private List<Card> loadcount()
        {
            List<Card> card = new List<Card>();
            card.AddRange(gameState.GetDeck().GetAllCards());//남은 덱 가져오기
            card.Sort((a, b) =>
            {
                int typeCompare =
                    a.GetCardType().CompareTo(b.GetCardType());

                if (typeCompare != 0)
                    return typeCompare;

                return a.GetMissionValue().CompareTo(b.GetMissionValue());
            });
            return card;

        }

        private void ShowDeck()
        {
            List<Card> cards = loadcount();

            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();

            foreach (Card card in cards)
            {
                Panel targetPanel = GetPanelByCardType(card.GetCardType());

                PictureBox pb = new PictureBox();

                pb.Size = new Size(
                    (int)(CARD_BASE_WIDTH * scaler.ScaleX),
                    (int)(CARD_BASE_HEIGHT * scaler.ScaleY));

                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = GetCardImage(card);

                int index = targetPanel.Controls.Count;

                pb.Location = new Point(
                    (int)(index * CARD_GAP * scaler.ScaleX),
                    (int)(CARD_MARGIN_Y * scaler.ScaleY));

                targetPanel.Controls.Add(pb);
                pb.BringToFront();
            }
        }

        private Panel GetPanelByCardType(CardType type) //모양별로 들어갈 판넬
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

        Image GetCardImage(Card card) //이미지 불러오기
        {
            string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png";

            string path = Path.Combine(
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