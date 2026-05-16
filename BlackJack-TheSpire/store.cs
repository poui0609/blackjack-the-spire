using BlackJack_TheSpire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }
        List<Card> randomCards;
        List<Item> randomItems;
        int item1, item2, item3, card1, card2, card3; //아이템과 카드 번호 저장하는 변수
        int safe;


        private void store_Load(object sender, EventArgs e) //랜덤 돌려서 아이템 채워넣기, 카드 채워넣기
        {
            randomCards = new List<Card>();

            for (int i = 0; i < 3; i++)
            {
                CardType[] allTypes = (CardType[])Enum.GetValues(typeof(CardType));
                CardValue[] allValues = (CardValue[])Enum.GetValues (typeof(CardValue));
                Card randomCard = new Card(allTypes[GameRandom.Next(allTypes.Length)], allValues[GameRandom.Next(allValues.Length)]);
                randomCards.Add(randomCard);
            }

            randomItems = new List<Item>();

            for(int i = 0;i < 3; i++)
            {
                randomItems.Add(ItemManager.GetRandomItem());
            }
            label1.Text = randomItems[0].Name + "\n" + randomItems[0].Description;

            label2.Text = randomItems[1].Name + "\n" + randomItems[1].Description;

            label3.Text = randomItems[2].Name + "\n" + randomItems[2].Description;

            label4.Text = "보유 코인: " + gameState.GetCoin().ToString();
        }

        private void selectbtn1_Click(object sender, EventArgs e)
        {
            pushitem(0);
        }

        private void selectbtn2_Click(object sender, EventArgs e)
        {
            pushitem(1);
        }

        private void pass_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectbtn3_Click(object sender, EventArgs e)
        {
            pushitem(2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pushdeck(int index) //덱에 넣는 명령어
        {
            Card selectedCard = randomCards[index];
            gameState.GetDeck().AddCard(selectedCard);
        }
        private void pushitem(int index) //아이템에 넣는 명령어
        {
            Item selectedItem = randomItems[index];

            if (gameState.GetCoin() >= selectedItem.Price)
            {
                gameState.SubtractCoin(selectedItem.Price);
                gameState.AddItem(selectedItem);

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
    }
}
