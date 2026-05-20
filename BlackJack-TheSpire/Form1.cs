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
        CycleManager cycleManager;
        RoundManager roundManager;
        private int fold_num = 0; //폴드 횟수
        private Label[] itemSlots; //아이템 슬롯 변수
        private Label selectedSlot; //아이템 슬롯 저장 변수
        public Form1()
        {
            InitializeComponent();
            start gamestart = new start();
            if (gamestart.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }
            gameState = gamestart.SelectedGameState;

            roundManager = new RoundManager(gameState);
            cycleManager = new CycleManager(gameState, roundManager);
            gameState.GetDeck().Shuffle();
            itemSlots = new Label[] {item1, item2, item3, item4, item5 };
            cycleManager.StartCycle();
            RefreshInventory(); showscore(); showround(); showcoin(); shownumodds(); showfoldnum(); ShowMission();
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
            score.Text = $"{gameState.GetCycleScore().ToString()} / {gameState.GetTargetScore().ToString()}";
        }
        void showround() // 남은 턴 보여주는 메소드.
        {
            round.Text = $"{gameState.GetCurrentRound().ToString()} / 4";
        }
        void shownumodds() //배율, 숫자 보여주는 메소드
        {
            Hand hand = roundManager.GetPlayerHand();

            int value = hand.CalculateValue();
            double odd = ScoreCalculator.GetHandMultiplier(hand);
            num.Text = value.ToString();
            odds.Text = odd.ToString();
            get.Text = $"받는 점수 :{Math.Ceiling(value * odd).ToString()}";
        }
        void showfoldnum()
        {
            foldnum.Text = $"{fold_num.ToString()}";
        }
        private void foldbutten_Click(object sender, EventArgs e)
        {
            if (!roundManager.Fold())
            {
                MessageBox.Show("폴드를 할 수 없습니다.");
                return;
            }
            fold_num++;
            playerhandpanel.Controls.Clear();
            showscore();
            showfoldnum();
            shownumodds();
        }
        private void draw_Click(object sender, EventArgs e)
        {
            Card drawCard = roundManager.Draw();
            if (drawCard == null)
                return;
            ShowPlayerHand(drawCard);
            CheckMission();             //미션 성공했는지 확인하는 코드
            shownumodds();
        }

        private void stand_Click(object sender, EventArgs e)
        {
            roundManager.Stand();
            cycleManager.OnRoundEnd();

            playerhandpanel.Controls.Clear();

            shownumodds();
            showscore();
            showround();
            if (cycleManager.IsCycleSuccess())
            {
                showcoin();

                store store = new store(gameState);
                store.ShowDialog();

                RefreshInventory(); showcoin(); showfoldnum();

                cycleManager.GoToNextCycle();

                SaveManager.Save(gameState);    //저장
            }
        }
        private void deck_count_Click(object sender, EventArgs e)//남은덱
        {
            DeckCount deckCount = new DeckCount(gameState);
            deckCount.ShowDialog();
        }

        private void deck_Click(object sender, EventArgs e) //전체 덱
        { 
            HaveDeck haveDeck = new HaveDeck(gameState);
            haveDeck.ShowDialog();
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
        Image GetCardImage(Card card) //사용법 : Resources 폴더에 넣으면 됌
        {
            // string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png";
            string fileName = "card.png";
            string path = Path.Combine(Application.StartupPath,"..","..","Resources",fileName);
            path = Path.GetFullPath(path);
            return Image.FromFile(path);
        }

        public void RefreshInventory() //인벤토리 아이템 표시
        {
            for (int i = 0; i < itemSlots.Length; i++)
            {
                itemSlots[i].Text = "";
            }
            List<Item> items = gameState.GetInventory().GetItems();
            for (int i = 0; i < items.Count && i < itemSlots.Length; i++)
            {
                itemSlots[i].Text = items[i].Name +"\n" + items[i].Description;
            }
        }

        void ShowMission()
        {
            List<Mission> missions = gameState.GetCurrentMissions();
            if(missions.Count > 0)
            {
                Mission1.Text = missions[0].Name + "\n" + missions[0].Description + "\n배율: X" + missions[0].BonusMultiplier;
            }
            if(missions.Count > 1)
            {
                Mission2.Text = missions[1].Name + "\n" + missions[1].Description + "\n배율: X" + missions[1].BonusMultiplier;
            }
        }

        void CheckMission()
        {
            Hand hand = roundManager.GetPlayerHand();
            List<Mission> missions = gameState.GetCurrentMissions();

            foreach (Mission mission in missions)
            {
                if (!mission.IsCompleted && mission.Check(hand))
                    mission.IsCompleted = true;
            }

            if (missions.Count > 0 && missions[0].IsCompleted)
                Mission1.Text = "미션 성공!";
            if (missions.Count > 1 && missions[1].IsCompleted)
                Mission2.Text = "미션 성공!";
        }
    }
}
