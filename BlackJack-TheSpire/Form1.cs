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
        private int value = 0; //숫자
        private double odd = 0; //배율
        private int fold_num = 0; //폴드 횟수
        public Form1()
        {
            InitializeComponent();
            GameRandom.SetRandomSeed();
            gameState = new GameState();
            currentHand = new Hand();
            gameState.GetDeck().Shuffle();
            set_cycle();
            showround();
            shownumodds();
            showscore();
            showcoin();
        }

        private void 룰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rules rules = new rules();
            rules.ShowDialog();
        }

        void showcoin() //코인 보여주는 메소드
        {
            coin.Text = $"코인 : {gameState.GetCoin().ToString()}";
        }
        void showscore() //점수 보여주는 메소드
        {
            score.Text = $"{gameState.GetRoundScore().ToString()} / {gameState.GetTargetScore().ToString()}";
        }
        void showround() // 남은 턴 보여주는 메소드.
        {
            round.Text = $"{gameState.GetCurrentRound().ToString()} / 4";
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
            if (fold_num > 4)
            {
                               MessageBox.Show("더 이상 폴드할 수 없습니다.");
                return;
            }
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
            currentHand.Clear();
            value = 0;
            odd = 1;
            playerhandpanel.Controls.Clear();
            gameState.NextRound();
            round_check();
            showround();
            shownumodds();
            showscore();
        }
        private void round_check() //라운드가 끝났는지
        {
            if(gameState.GetRoundScore() >= gameState.GetTargetScore())
            {
                gameState.SetCurrentRound(1);
                one_cycleend();
                return;
            }
            if (gameState.GetCurrentRound() > 4)
            {
                this.Close();
                //게임오버. 점수도 못넘겼고 라운드도 끝남.
                
            }
        }
        private void one_cycleend() //한 사이클 끝나면
        {
            int nowcoin = gameState.GetCoin();
            //돈 주는거.
            switch (gameState.GetCurrentRound())
            {
                case 1:
                    gameState.SetCoin(nowcoin + 6);
                    break;
                case 2:
                    gameState.SetCoin(nowcoin + 4);
                    break;
                case 3:
                    gameState.SetCoin(nowcoin + 2);
                    break;
            }
            gameState.SetCurrentCycle(gameState.GetCurrentCycle() + 1);
            showcoin();
            store store = new store(gameState);
            store.Show();
            //저장
            //불러오기
            set_cycle();
        }
        private void set_cycle() //사이클 점수 설정
        {
            if (gameState.GetCurrentCycle() < 3)
            {
                gameState.SetTargetScore(60); // 일반 목표점수
            }
            else if (gameState.GetCurrentCycle() == 3)
            {
                gameState.SetTargetScore(70); // 어려운 목표점수
            }
             else
            {
                gameState.SetTargetScore(15); // 보스 목표점수
                gameState.SetCurrentCycle(1);
                //보스 아이템 추가해주셈
            }
            gameState.SetRoundScore(0);
            fold_num = 0;
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
        Image GetCardImage(Card card) //사용법 : bin / debug / Cards 파일 안에
        {
            // string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png";
            //string path = Path.Combine(Application.StartupPath, "Cards", fileName);
            string path = Path.Combine(Application.StartupPath, "Cards", "card.png");
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
