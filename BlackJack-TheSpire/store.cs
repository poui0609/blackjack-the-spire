using BlackJack_TheSpire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_TheSpire
{
    public partial class store : Form
    {
        private GameState gameState;
        internal store(GameState gameState)
        {
            InitializeComponent();

            this.gameState = gameState;

            inventorySlots = new Label[] {slot1, slot2, slot3, slot4, slot5};   
            cardBoxes = new PictureBox[] { draw1, draw2, draw3 };
        }
        private Label[] inventorySlots;
        private Label selectedSlot;
        private PictureBox[] cardBoxes;

        List<Card> randomCards;
        List<Item> randomItems;
        int item1, item2, item3, card1, card2, card3; //아이템과 카드 번호 저장하는 변수
        int safe;



        private void store_Load(object sender, EventArgs e) //랜덤 돌려서 아이템 채워넣기, 카드 채워넣기
        {
            randomCards = new List<Card>();

            while (randomCards.Count < 3)
            {
                CardType[] allTypes = (CardType[])Enum.GetValues(typeof(CardType));
                CardValue[] allValues = (CardValue[])Enum.GetValues(typeof(CardValue));
                Card newCard = new Card(allTypes[GameRandom.Next(allTypes.Length)], allValues[GameRandom.Next(allValues.Length)]);
                bool exists = randomCards.Any(card => card.GetCardType() == newCard.GetCardType() && card.GetCardValue() == newCard.GetCardValue());
                if (!exists)
                {
                    randomCards.Add(newCard);
                }
            }

            randomItems = new List<Item>();

            for(int i = 0;i < 3; i++)
            {
                Item randomItem;
                do
                {
                    randomItem = ItemManager.GetRandomItem();
                }
                while (randomItems.Contains(randomItem));

                randomItems.Add(randomItem);
            }

            buy1.Text = randomItems[0].Name + "\n" + randomItems[0].Description + "\n" + randomItems[0].Price;
            buy2.Text = randomItems[1].Name + "\n" + randomItems[1].Description + "\n" + randomItems[1].Price;
            buy3.Text = randomItems[2].Name + "\n" + randomItems[2].Description + "\n" + randomItems[2].Price;

            cardBoxes[0].Image = GetCardImage(randomCards[0]);
            cardBoxes[1].Image = GetCardImage(randomCards[1]);
            cardBoxes[2].Image = GetCardImage(randomCards[2]);

            label4.Text = "보유 코인: " + gameState.GetCoin().ToString();

            RefreshInventory();

            pass.Enabled = false;
        }
        private void RefreshInventory() //인벤토리 아이템 표시
        {
            for (int i = 0; i < inventorySlots.Length; i++)
            {
                inventorySlots[i].Text = "";
            }
            List<Item> items = gameState.GetInventory().GetItems();
            for (int i = 0; i < items.Count && i < inventorySlots.Length; i++)
            {
                inventorySlots[i].Text = items[i].Name;
            }
        }

        private void selectbtn1_Click(object sender, EventArgs e)   //아이템 1번 구매
        {
            pushitem(0);
        }

        private void selectbtn2_Click(object sender, EventArgs e)   //아이템 2번 구매
        {
            pushitem(1);
        }

        private void pass_Click(object sender, EventArgs e)      //상점 나가기 
        {
            Close();
        }

        private void selectbtn3_Click(object sender, EventArgs e)        //아이템 3번 구매
        {
            pushitem(2);
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)  //마우스 우클릭 삭제 메소드
        {
            if (selectedSlot == null)
                return;

            int index =
                Array.IndexOf(inventorySlots, selectedSlot);

            if (index < 0)
                return;

            List<Item> items =
                gameState.GetInventory().GetItems();

            if (index >= items.Count)
                return;

            items.RemoveAt(index);

            RefreshInventory();
        }

        private void slot_MouseDown(object sender, MouseEventArgs e) //마우스 우클릭 메소드
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedSlot = (Label)sender;
            }
        }

        private void drawLabel_Click(object sender, EventArgs e) //카드 선택 메소드, 상점 폼 아래 어떤 카드를 선택할 것인지
        {
            PictureBox clickedBox = (PictureBox)sender;

            int index = Array.IndexOf(cardBoxes, clickedBox);

            if (index < 0)
                return;

            Card selectedCard = randomCards[index];

            gameState.GetDeck().AddCard(selectedCard);

            for (int i = 0; i < cardBoxes.Length; i++)
            {
                cardBoxes[i].Enabled = false;
                if (i != index)
                {
                    cardBoxes[i].Visible = false;
                }
            }
            pass.Enabled = true;

            MessageBox.Show(selectedCard.ToString() + " 카드가 덱에 추가되었습니다!");
        }

        private void pushitem(int index)                             //아이템을 인벤토리에 넣는 명령어
        {
            Item selectedItem = randomItems[index];

            if (gameState.GetCoin() >= selectedItem.Price)
            {
                bool success = gameState.GetInventory().AddItem(selectedItem);
                if (!success)
                {
                    MessageBox.Show("인벤토리가 가득 찼습니다!");
                    return;
                }
                
                gameState.SubtractCoin(selectedItem.Price);
                RefreshInventory();

                if (index == 0)
                    selectbtn1.Enabled = false;

                if (index == 1)
                    selectbtn2.Enabled = false;

                if (index == 2)
                    selectbtn3.Enabled = false;

                label4.Text = "보유 코인: " +gameState.GetCoin().ToString();
            }
            else
                MessageBox.Show("코인 부족!");
        }

        Image GetCardImage(Card card)                        //카드 이미지 넣는 메소드
        {
            string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png";
            string path = Path.Combine(Application.StartupPath, "..", "..", "Resources", fileName);
            path = System.IO.Path.GetFullPath(path);
            return Image.FromFile(path);
        }
    }
}
