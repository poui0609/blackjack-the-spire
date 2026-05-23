using BlackJack_TheSpire.Scaler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_TheSpire
{
    public partial class Form1 : Form
    {
        GameState gameState;
        CycleManager cycleManager;
        RoundManager roundManager;
        FormScaler scaler;

        PictureBox movingCard; //카드 움직이는 효과 때 사용
        Card drawCard; //마지막으로 뽑은 카드
        int targetX; //카드 움직일 때 어디까지 움직일지 저장하는 변수

        private int fold_num = 0; //폴드 횟수

        private Label[] itemSlots; //아이템 슬롯 변수
        private Label selectedSlot; //아이템 슬롯 저장 변수

        // 카드 기준 수치 (디자인 시 기준값) - 양쪽 메서드에서 공유
        private const int CARD_BASE_WIDTH = 159;
        private const int CARD_BASE_HEIGHT = 220;
        private const int CARD_GAP = 100;       // 카드 사이 간격
        private const int CARD_MARGIN_Y = 10;   // 카드 위쪽 여백

        public Form1()
        {
            InitializeComponent();

            scaler = new FormScaler(this);

            // 이벤트 연결
            this.Resize += Form1_CardResize;

            start gamestart = new start();
            if (gamestart.ShowDialog() != DialogResult.OK) //시작화면에서 버튼을 통해서 껐는지 확인. 잘못된 경로면 종료
            {
                this.Close();
                return;
            }
            gameState = gamestart.SelectedGameState; //저장정보 반영

            roundManager = new RoundManager(gameState);
            cycleManager = new CycleManager(gameState, roundManager);
            gameState.GetDeck().Shuffle();
            itemSlots = new Label[] { item1, item2, item3, item4, item5 };
            cycleManager.StartCycle();
            RefreshInventory(); showscore(); showround(); showcoin(); shownumodds(); showfoldnum(); ShowMission();
        }

        private void Form1_CardResize(object sender, EventArgs e)
        {
            ResizePlayerCards();
        }

        private void ResizePlayerCards()
        {
            int index = 0;

            foreach (Control ctrl in playerhandpanel.Controls)
            {
                if (ctrl is PictureBox card)
                {
                    card.Size = new Size(
                        (int)(CARD_BASE_WIDTH * scaler.ScaleX),
                        (int)(CARD_BASE_HEIGHT * scaler.ScaleY));

                    card.Location = new Point(
                        (int)(index * CARD_GAP * scaler.ScaleX),
                        (int)(CARD_MARGIN_Y * scaler.ScaleY));

                    index++;
                }
            }
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

            if (hand.GetCardCount() == 0) { num.Text = "0"; odds.Text = "0"; get.Text = "받는 점수: 0"; return; };  //사이클 종료 후 메인 폼 UI 갱신

            int value = hand.CalculateValue();
            double baseOdd = ScoreCalculator.GetHandMultiplier(hand);
            double totalMultiplier = baseOdd;
            string oddsText = baseOdd.ToString("0.0");

            foreach (Mission mission in gameState.GetCurrentMissions())
            {
                if (mission.IsCompleted)
                {
                    totalMultiplier *= mission.BonusMultiplier;
                    oddsText += " x " + mission.BonusMultiplier.ToString("0.0");
                }
            }

            foreach (Item item in gameState.GetInventory().GetItems())
            {
                double beforeMultiplier = totalMultiplier;
                totalMultiplier = item.Effect(gameState, hand, totalMultiplier);

                if (beforeMultiplier != totalMultiplier)
                {
                    double itemMultiplier = totalMultiplier / beforeMultiplier;
                    oddsText += " x " + itemMultiplier.ToString("0.0");
                }
            }
            int finalScore = (int)(value * totalMultiplier);
            num.Text = value.ToString();
            odds.Text = oddsText + " = " + totalMultiplier.ToString("0.0");
            get.Text = $"받는 점수: {finalScore}";
        }

        void showfoldnum() //폴드 수 보여주는 메소드
        {
            foldnum.Text = $"{fold_num.ToString()}";
        }

        private void foldbutten_Click(object sender, EventArgs e)
        {
            if (!roundManager.Fold()) //폴드 수행. 폴드 불가능시 메시지 후 종료
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
            Card drawCard = roundManager.Draw(); //카드뽑기
            if (drawCard == null)
                return;

            this.drawCard = drawCard; //마지막으로 뽑은 카드 저장
            ShowPlayerHand(); //손패 이미지 추가
            CheckMission(); //미션 성공했는지 확인하는 코드
            shownumodds();
        }

        private void stand_Click(object sender, EventArgs e)
        {
            roundManager.Stand();
            cycleManager.OnRoundEnd();

            playerhandpanel.Controls.Clear();

            shownumodds();
            showscore();
            showround(); //스탠드 = 라운드 종료. 화면상 라운드 정보들 업데이트

            if (cycleManager.IsCycleSuccess()) // 사이클이 끝나면
            {
                showcoin();

                store store = new store(gameState);
                store.ShowDialog();

                RefreshInventory(); showcoin(); showfoldnum();

                cycleManager.GoToNextCycle();

                ShowMission();
                shownumodds();                //사이클 끝나고 메인 폼 화면 UI 갱신
                showround();

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

        private void ShowPlayerHand()
        {
            movingCard = new PictureBox();

            movingCard.BorderStyle = BorderStyle.None; //테두기 제거
            movingCard.BackColor = Color.Transparent; //색 투명
            movingCard.SizeMode = PictureBoxSizeMode.StretchImage; // 크기가 이미지 크기에 따라 조절되지 않게 고정
            movingCard.AutoSize = false;

            // 카드 기준 크기에 비율 적용
            movingCard.Size = new Size(
                (int)(CARD_BASE_WIDTH * scaler.ScaleX),
                (int)(CARD_BASE_HEIGHT * scaler.ScaleY));

            string path = @"..\..\Resources\card.png";
            movingCard.Image = Image.FromFile(path); //뒷면이 쭉 이동

            int index = playerhandpanel.Controls.Count;

            // 최종 도착 위치 (카드 간격에 비율 적용)
            targetX = (int)(index * CARD_GAP * scaler.ScaleX);

            // 시작 위치 (오른쪽 밖, Y 여백에 비율 적용)
            movingCard.Location = new Point(
                playerhandpanel.Width,
                (int)(CARD_MARGIN_Y * scaler.ScaleY));

            playerhandpanel.Controls.Add(movingCard); //패널에 카드 추가

            movingCard.BringToFront(); // 최근거가 겹쳐보이게

            draw_impact();
        }

        private void draw_impact()
        {
            moveTimer.Stop();

            // 중복 연결 방지
            moveTimer.Tick -= MoveCard;
            moveTimer.Tick += MoveCard;

            moveTimer.Interval = 10;
            moveTimer.Start();
        }

        private async void MoveCard(object sender, EventArgs e)
        {
            int speed = 15;

            movingCard.Left -= speed;

            // 목표 위치 도착
            if (movingCard.Left <= targetX)
            {
                movingCard.Left = targetX;

                await Task.Delay(100); //0.1초 대기

                movingCard.Image = GetCardImage(drawCard); //뒷면에서 카드로 이미지 변경
                moveTimer.Stop();
            }
        }

        Image GetCardImage(Card card) //사진 가져오기
        {
            string fileName = card.GetCardType() + "_" + card.GetCardValue() + ".png"; //이름설정
            string path = Path.Combine(Application.StartupPath, "..", "..", "Resources", fileName); //경로설정
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
                itemSlots[i].Text = items[i].Name + "\n" + items[i].Description;
            }
        }

        void ShowMission()
        {
            List<Mission> missions = gameState.GetCurrentMissions();
            if (missions.Count > 0)
            {
                Mission1.Text = missions[0].Name + "\n" + missions[0].Description + "\n배율: X" + missions[0].BonusMultiplier;
            }
            if (missions.Count > 1)
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
<<<<<<< Updated upstream
=======

        private void 나가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamestarting();
        }

        private void 게임종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 확인용 메시지 박스
            DialogResult result = MessageBox.Show(
                "정말로 게임을 종료하시겠습니까?",
                "게임 종료",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // 프로그램 종료
            }
            // No 선택하면 아무 일도 없음
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardType type =
        (CardType)Enum.Parse(typeof(CardType), cbtype.SelectedItem.ToString());

            CardValue value =
                (CardValue)Enum.Parse(typeof(CardValue), cbvalue.SelectedItem.ToString());

            Card newCard = new Card(type, value);

            gameState.GetDeck().AddCard(newCard); // 카드 추가

            MessageBox.Show($"{type} {value} 카드가 추가되었습니다.");
        }

        private void 제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardType type =
        (CardType)Enum.Parse(typeof(CardType), cbtype.SelectedItem.ToString());

            CardValue value =
                (CardValue)Enum.Parse(typeof(CardValue), cbvalue.SelectedItem.ToString());

            List<Card> cards = gameState.GetDeck().GetAllCards();

            Card targetCard = cards.FirstOrDefault(card =>card.GetCardType() == type && card.GetCardValue() == value); //덱에서 해당 카드 있는지 확인

            if (targetCard == null)
            {
                MessageBox.Show("해당 카드가 덱에 없습니다.");
                return;
            }

            cards.Remove(targetCard); //있으면 제거

            MessageBox.Show($"{type} {value} 카드가 덱에서 제거되었습니다.");
        }
>>>>>>> Stashed changes
    }
}
