using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BlackJack_TheSpire
{
    public partial class Form1 : Form
    {
        GameState gameState;
        Hand currentHand;
        public Form1()
        {
            InitializeComponent();
            GameRandom.SetRandomSeed();
            gameState = new GameState();
            currentHand = new Hand();
            gameState.GetDeck().Shuffle();
        }

        private void 룰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rules rules = new rules();
            rules.ShowDialog();
        }

        private int value = 0; //숫자
        private double odd = 0; //배율

        void showcoin() //코인 보여주는 메소드
        {
            coin.Text = $"코인 : {gameState.GetCoin().ToString()}";
        }
        void showscore() //점수 보여주는 메소드
        {
            score.Text = $"{gameState.GetRoundScore().ToString()} / {gameState.GetTargetScore().ToString()}";
        }
        void showturn() // 남은 턴 보여주는 메소드.
        {
            turn.Text = $"{gameState.GetCurrentRound().ToString()} / 4";
        }
        void shownumodds()
        {
            value = currentHand.CalculateValue();
            odd = ScoreCalculator.GetHandMultiplier(currentHand);
            num.Text = value.ToString();
            odds.Text = odd.ToString();
            get.Text = $"받는 점수 :{Math.Ceiling(value * odd).ToString()}";
        }


        private void foldbutten_Click(object sender, EventArgs e)
        {
            currentHand.Clear();
            value = 0;
            odd = 1;
            int score = gameState.GetRoundScore();
            if (score > 0)
            {
                gameState.SetRoundScore(score / 2);
            }
            shownumodds();
            showscore();
            playerhandpanel.Controls.Clear();
        }




        private void draw_Click(object sender, EventArgs e)
        {
            Card newcard = gameState.GetDeck().Draw();
            currentHand.AddCard(newcard);
            ShowPlayerHand(newcard);
            shownumodds();
        }

        private void stand_Click(object sender, EventArgs e)
        {
            gameState.SetRoundScore((int)(gameState.GetRoundScore() + value * odd));
            value = 0;
            odd = 1;
            playerhandpanel.Controls.Clear();
            gameState.NextRound();
            showturn();
            shownumodds();
            showscore();
            라운드끝();
        }

        private void 라운드끝()
        {
            //돈 주는거.
            showcoin();
            store store = new store(gameState);
            store.Show();
        }

        private void deck_count_Click(object sender, EventArgs e)//남은덱
        {
            //남은 덱 보여주세요
        }

        private void deck_Click(object sender, EventArgs e) //전체 덱
        {
            //자기 덱 보여줄거 모달로다가
        }
        private void ShowPlayerHand(Card card)
        {
            PictureBox pb = new PictureBox();

            pb.Size = new Size(100, 300);
            pb.Image = GetCardImage(card);

            int index = playerhandpanel.Controls.Count;

            pb.Location = new Point(index * 50, 10);

            playerhandpanel.Controls.Add(pb);

            pb.BringToFront();
        }
        Image GetCardImage(Card card)
        {
            // string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png";
            string fileName = "card.png";
            string path = Path.Combine(Application.StartupPath, "Cards", fileName);

            return Image.FromFile(path);
        }

        private void RefreshInventory() //인벤토리 아이템 표시
        {
            /*
            inventoryList.Items.Clear();
            foreach(Item item in gameState.GetInventory())
            {
                inventoryList.Items.Add(item.Name);
            }
            */
        }
    }
}
