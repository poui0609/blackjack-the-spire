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

        GameState SelectedGameState; //시작할 때 불러오기 할 데이터

        PictureBox movingCard; //카드 움직이는 효과 때 사용
        Card drawCard; //마지막으로 뽑은 카드
        int targetX; //카드 움직일 때 어디까지 움직일지 저장하는 변수

        private int fold_num = 0; //폴드 횟수

        private Label[] itemSlots; //아이템 슬롯 변수
        private Label selectedSlot; //아이템 슬롯 저장 변수
        private List<Mission> currentRoundCompletedMissions = new List<Mission>();

        // 카드 기준 수치 (디자인 시 기준값) - 양쪽 메서드에서 공유
        private const int CARD_BASE_WIDTH = 145;
        private const int CARD_BASE_HEIGHT = 200;
        private const int CARD_GAP = 100;       // 카드 사이 간격
        private const int CARD_MARGIN_Y = 10;   // 카드 위쪽 여백


        private bool isCardMoving = false; //카드 움직일 때 못움직이게
        public Form1()
        {
            InitializeComponent();

            scaler = new FormScaler(this);

            // 화면크기 조정 이벤트 연결
            this.Resize += Form1_CardResize;

            InitItemShow();
            InitTutorialImage();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            draw.Enabled = false;       //시작버튼 누르기 전에는 비활성화
            foldbutten.Enabled = false;
            stand.Enabled = false;
            deck.Enabled = false;

        }
        public void gamestarting()
        {
            gameState = SelectedGameState; //저장정보 반영

            newbtn.Visible = false;         //시작화면 버튼들 지우기
            continuebtn.Visible = false;
            tutorial.Visible = false;

            roundManager = new RoundManager(gameState);
            cycleManager = new CycleManager(gameState, roundManager);
            itemSlots = new Label[] { item1, item2, item3, item4, item5 };
            cycleManager.StartCycle();

            RefreshInventory(); showscore(); showround(); showcoin(); shownumodds(); showfoldnum(); ShowMission(); ShowBoss(); shownowround();//게임 시작 후 메인 폼 UI 갱신


            deck.Enabled = true;//버튼들 활성화
            UpdateButtonState();
        }

        private void Form1_CardResize(object sender, EventArgs e)
        {
            ResizePlayerCards();
            if (tutorialLabel.Visible)
            {
                float scale = Math.Min(scaler.ScaleX, scaler.ScaleY);   //글씨 크기조절

                tutorialLabel.Font = new Font("맑은 고딕",10f * scale,FontStyle.Bold);

                ApplyCurrentTutorialLayout();
            }
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

        private void UpdateButtonState() //버튼 활성화 비활성화
        {
            int cardCount = roundManager.GetPlayerHand().GetCardCount();

            draw.Enabled = !roundManager.IsRoundOver(); //점수 오버되서 못뽑을 때 비활성화
            if (draw.Enabled)
            {
                drawwarring(); //드로우 버튼 테두리 강조
            }

            foldbutten.Enabled = roundManager.CanFold() && cardCount > 0; ;//점수가 1점이하라 폴드 못할 때 비활성화, 카드를 안뽑았으면 비활성화

            stand.Enabled = cardCount >= 2; //2장 이상 뽑은 후부터 스탠드 가능하게 활성화
        }
        private void drawwarring() // 16이상이면 드로우 버튼 테두리 강조
        {
            int value = roundManager.GetPlayerHand().CalculateValue();

            if (value >= 16)
            {
                draw.FlatStyle = FlatStyle.Flat;
                draw.FlatAppearance.BorderSize = 4;
                draw.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                draw.FlatAppearance.BorderSize = 1;
                draw.FlatAppearance.BorderColor = Color.Black;
            }
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

            if (hand.GetCardCount() == 0) { num.Text = "0"; odds.Text = "0"; get.Text = "받는 점수: 0"; return; }
            ;  //사이클 종료 후 메인 폼 UI 갱신

            int value = hand.CalculateValue();
            double baseOdd = ScoreCalculator.GetHandMultiplier(hand);
            double extraMultiplier = 1.0;
            double totalMultiplier = baseOdd;
            string oddsText = baseOdd.ToString("0.0");

            foreach (Mission mission in roundManager.GetCurrentRoundCompletedMissions())
            {
                extraMultiplier *= mission.BonusMultiplier;
                totalMultiplier *= mission.BonusMultiplier;
            }

            foreach (Item item in gameState.GetInventory().GetItems())
            {
                double beforeMultiplier = totalMultiplier;
                totalMultiplier = item.Effect(gameState, hand, totalMultiplier);

                if (beforeMultiplier != totalMultiplier)
                {
                    double itemMultiplier = totalMultiplier / beforeMultiplier;
                    extraMultiplier *= itemMultiplier;
                }
            }
            Boss boss = gameState.GetCurrentBoss();

            if (boss != null)
            {
                double beforeMultiplier = totalMultiplier;
                totalMultiplier = boss.Effect(gameState, hand, totalMultiplier);

                if (beforeMultiplier != totalMultiplier)
                {
                    double bossMultiplier = totalMultiplier / beforeMultiplier;
                    extraMultiplier *= bossMultiplier;
                }
            }
            int finalScore = (int)(value * totalMultiplier);
            num.Text = value.ToString();
            odds.Text = baseOdd.ToString("0.0") + " x " + extraMultiplier.ToString("0.0") + " = " + totalMultiplier.ToString("0.0");
            get.Text = $"받는 점수: {finalScore}";
        }

        void showfoldnum() //폴드 수 보여주는 메소드
        {
            foldnum.Text = $"{fold_num.ToString()}";
        }
        void ShowBoss() //보스 보여주는 메소드
        {
            Boss boss = gameState.GetCurrentBoss();

            if (boss == null)
            {
                bosslbl.Text = "";
                return;
            }

            bosslbl.Text = boss.Name + "\n" + boss.Description;
        }
        void shownowround()
        {
            nowround.Text = $"{gameState.GetCurrentChapter()}-{gameState.GetCurrentCycle()}";
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

            UpdateButtonState();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            if (isCardMoving) //이동중이면 안눌리게
                return;

            Card drawCard = roundManager.Draw(); //카드뽑기
            if (drawCard == null) // 뽑을 카드 없으면 끝
            {
                MessageBox.Show("모든 카드를 뽑았습니다.");
                ending end = new ending(gameState);
                end.ShowDialog();

                this.Close();
                return;
            }
            this.drawCard = drawCard; //마지막으로 뽑은 카드 저장
            ShowPlayerHand(); //손패 이미지 추가
            CheckMission(); //미션 성공했는지 확인하는 코드
            shownumodds();

            UpdateButtonState();
        }

        private void stand_Click(object sender, EventArgs e)
        {
            int beforeCoin = gameState.GetCoin();
            roundManager.Stand();
            cycleManager.OnRoundEnd();
            int earnedCoin = gameState.GetCoin() - beforeCoin;    //사이클에서 얻은 코인 수

            if (cycleManager.IsGameOver()||gameState.IsGameClear())
            {
                ending end = new ending(gameState);
                end.ShowDialog();

                this.Close();
                return;
            }

            playerhandpanel.Controls.Clear();

            shownumodds();
            showscore();
            showround(); //스탠드 = 라운드 종료. 화면상 라운드 정보들 업데이트

            UpdateButtonState();


            if (cycleManager.IsCycleSuccess()) // 사이클이 끝나면
            {
                RoundClear roundClear = new RoundClear(gameState, gameState.GetCurrentCycle(), gameState.GetCycleScore(), gameState.GetTargetScore(), earnedCoin);
                roundClear.ShowDialog();                                            // 사이클 종료 후 클리어 화면 띄우기

                showcoin();

                store store = new store(gameState);
                store.ShowDialog();

                RefreshInventory(); showcoin(); showfoldnum();

                cycleManager.GoToNextCycle();

                ShowMission();
                shownumodds();                //사이클 끝나고 메인 폼 화면 UI 갱신
                showround();
                showscore();
                ShowBoss();
                shownowround();

                UpdateButtonState();

                SaveManager.Save(gameState);    //저장
            }
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

            int index = playerhandpanel.Controls.OfType<PictureBox>().Count();

            // 최종 도착 위치 (카드 간격에 비율 적용)
            targetX = (int)(index * CARD_GAP * scaler.ScaleX);

            // 시작 위치 (오른쪽 밖, Y 여백에 비율 적용)
            movingCard.Location = new Point(
                playerhandpanel.ClientSize.Width,
                (int)(CARD_MARGIN_Y * scaler.ScaleY));

            playerhandpanel.Controls.Add(movingCard); //패널에 카드 추가

            movingCard.BringToFront(); // 최근거가 겹쳐보이게

            draw_impact();
        }

        private void draw_impact()
        {
            moveTimer.Stop();

            isCardMoving = true;

            // 중복 연결 방지
            moveTimer.Tick -= MoveCard;
            moveTimer.Tick += MoveCard;

            moveTimer.Interval = 10;
            moveTimer.Start();
        }

        private void MoveCard(object sender, EventArgs e)
        {
            int speed = 30;

            movingCard.Left -= speed;

            // 목표 위치 도착
            if (movingCard.Left <= targetX)
            {
                movingCard.Left = targetX;

                movingCard.Image = CardImageLoader.GetCardImage(drawCard); //뒷면에서 카드로 이미지 변경

                isCardMoving = false;

                moveTimer.Stop();
            }
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
                itemSlots[i].Text = items[i].Name + "\n\n" + items[i].Description;
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
                {
                    mission.IsCompleted = true;
                    currentRoundCompletedMissions.Add(mission);
                }
            }

            if (missions.Count > 0 && missions[0].IsCompleted)
                Mission1.Text = "미션 성공!";
            if (missions.Count > 1 && missions[1].IsCompleted)
                Mission2.Text = "미션 성공!";
        }

        private void 카드추가ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CardType type = (CardType)Enum.Parse(typeof(CardType), cbtype.SelectedItem.ToString());

            CardValue value = (CardValue)Enum.Parse(typeof(CardValue), cbvalue.SelectedItem.ToString());

            Card newCard = new Card(type, value);

            gameState.GetDeck().AddCard(newCard); // 카드 추가

            MessageBox.Show($"{type} {value} 카드가 추가되었습니다.");
        }

        private void 카드삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardType type = (CardType)Enum.Parse(typeof(CardType), cbtype.SelectedItem.ToString());

            CardValue value = (CardValue)Enum.Parse(typeof(CardValue), cbvalue.SelectedItem.ToString());

            List<Card> cards = gameState.GetDeck().GetAllCards();

            Card targetCard = cards.FirstOrDefault(card => card.GetCardType() == type && card.GetCardValue() == value); //덱에서 해당 카드 있는지 확인

            if (targetCard == null)
            {
                MessageBox.Show("해당 카드가 덱에 없습니다.");
                return;
            }

            cards.Remove(targetCard); //있으면 제거

            MessageBox.Show($"{type} {value} 카드가 덱에서 제거되었습니다.");


        }

        void InitItemShow()
        {
            ItemCombo.Items.Clear();
            foreach (Item item in ItemManager.allItems)
            {
                ItemCombo.Items.Add(item.Name);
            }
            if (ItemCombo.Items.Count > 0)
            {
                ItemCombo.SelectedIndex = 0;
            }
        }
        private void addItem_Click(object sender, EventArgs e)
        {
            if (ItemCombo.SelectedIndex < 0)
                return;
            Item selectedItem = ItemManager.allItems[ItemCombo.SelectedIndex];
            bool success = gameState.AddItem(selectedItem);

            if (!success)
            {
                MessageBox.Show("인벤토리가 가득 찼습니다.");
                return;
            }

            RefreshInventory();

            MessageBox.Show(selectedItem.Name + " 아이템 추가 완료!");
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            if (ItemCombo.SelectedIndex < 0)
                return;

            Item selectedItem = ItemManager.allItems[ItemCombo.SelectedIndex];
            List<Item> items = gameState.GetInventory().GetItems();
            Item target = items.FirstOrDefault(i => i.Id == selectedItem.Id);

            if (target == null)
            {
                MessageBox.Show("해당 아이템이 없습니다.");
                return;
            }

            gameState.RemoveItem(target);
            RefreshInventory();
            MessageBox.Show(target.Name + " 아이템 삭제 완료!");
        }

        private void 게임종료ToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void deck_Click_1(object sender, EventArgs e)
        {
            HaveDeck haveDeck = new HaveDeck(gameState, 0);
            haveDeck.ShowDialog();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            GameRandom.SetRandomSeed();

            SelectedGameState = new GameState(); //새로운 저장정보

            SelectedGameState.GetDeck().Shuffle();
            RoundManager roundManager = new RoundManager(SelectedGameState);
            CycleManager cycleManager = new CycleManager(SelectedGameState, roundManager);
            SaveManager.Save(SelectedGameState); //새로운 정보로 저장

            gamestarting(); //게임 시작

        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            if (!SaveManager.HasSaveFile())
            {
                MessageBox.Show("저장 파일이 없습니다.");
                return;
            }

            SelectedGameState = SaveManager.Load(); //기존정보 불러오기

            gamestarting(); //게임 시작
        }
        int tutorialClickCount = 0;
        private PictureBox tutorialImage;
        private void tutorial_Click(object sender, EventArgs e)
        {
            newbtn.Visible = false;         //시작화면 버튼들 지우기
            continuebtn.Visible = false;
            tutorial.Visible = false;

            tutorialLabel.Visible = true; //튜토리얼 라벨 활성화

            tutorialClickCount = 0;

            SetTutorialLabelLayout(300, 200, 550, 300);

            tutorialLabel.Text = "[게임의 흐름]\r\n총 6개의 챕터가 존재한다.\r\n\r\n각 챕터는 4번의 사이클로 구성된다.\r\n\r\n한 사이클에서는최대 4번의 블랙잭 라운드를 진행한다.\r\n\r\n목표 점수를 달성하면다음 사이클로 넘어갈 수 있다.\r\n\r\n각 게임이 끝나면 상점에서 아이템을 구매하거나 카드를 추가할 수 있다.\r\n\r\n챕터의 4번째 사이클에서는 강력한 디버프가 적용된다.\r\n(클릭하여 다음으로)";

            string path = Path.Combine(Application.StartupPath,"..","..","Resources","튜토리얼.jpg");

            path = Path.GetFullPath(path);

            tutorialLabel.BackgroundImage = Image.FromFile(path);
            tutorialLabel.BackgroundImageLayout = ImageLayout.Stretch;

            tutorialLabel.BringToFront();
        }
        private void TutorialLabel_Click(object sender, EventArgs e)
        {
            tutorialClickCount++;
            switch (tutorialClickCount)
            {
                case 1:
                    SetTutorialLabelLayout(300, 140, 550, 380);
                    tutorialLabel.Text = "[플레이 방식과 점수]\r\n카드를 뽑아 점수를 만든다.\r\n\r\nA = 1 또는 11\r\n2~10 = 숫자 그대로\r\nJ, Q, K = 10점\r\n\r\n21을 초과하면 Bust! 해당 라운드는 실패한다.\r\n\r\nSTAND를 선택하면 현재 손패의 점수를 확정한다.\r\n\r\n획득 점수는 [손패 점수] × [배율]로 계산된다.\r\n\r\n배율은\r\n카드 조합 X 아이템 효과 X미션 효과\r\n에 의해 증가한다.\r\n\r\n높은 점수와 높은 배율을 동시에 노리는 것이 핵심이다.\r\n(클릭하여 다음으로)";
                    break;

                case 2:
                    SetTutorialLabelLayout(250, 30, 350, 190);

                    tutorialLabel.Text = "코인 : 보유하고 있는 돈\r\n\r\n한판 이후 나오는 상점에서\r\n아이템을 살 수 있습니다.\r\n\r\n매 라운드에서\r\n남아있는돈 5원당 1원\r\n클리어시4원\r\n남아있는 라운드당 2원\r\n";
                    break;
                case 3:
                    SetTutorialLabelLayout(250, 120, 350, 190);

                    tutorialLabel.Text = "점수\r\n\r\n챕터별로 기본 80점\r\n+\r\n플레이 사이클마다 +20점 누적\r\n\r\n목표점수를 채우면\r\n다음 사이클로 넘어갈 수 있다\r\n\r\n점수를 채워 클리어하면 상점이 나온다";
                    break;
                case 4:
                    SetTutorialLabelLayout(250, 190, 350, 120);

                    tutorialLabel.Text = "숫자 : 카드 숫자의 총 합\r\n배율 : [카드조합에 해당하는 배율]\r\n*\r\n[추가배율(아이템 및 미션)]\r\n\r\n받는점수 : 숫자 * 배율로 나온 점수";
                    break;
                case 5:
                    SetTutorialLabelLayout(250, 300, 350, 170);

                    tutorialLabel.Text = "라운드\r\n판마다 4개의 라운드\r\n4라운드 안에 목표 점수를 채우면 클리어\r\n\r\n폴드\r\n패가 마음에 들지 않을 때\r\n패를 버리는 대신 현재 점수의 절반을 버림으로\r\n라운드 재시작  매 판 최대 4번";
                    break;
                case 6:
                    SetTutorialLabelLayout(250, 300, 350, 320);

                    tutorialLabel.Text = "드로우\r\n카드 뽑기\r\n단, 숫자가 21이 넘어 버스트 시\r\n뽑을 수 없다\r\n숫자가 16이상일 시 경고\r\n\r\n폴드\r\n점수를 절반 잃는 대신 라운드 재시작\r\n단, 점수가 없을 시 할 수 없다\r\n\r\n스탠드\r\n해당 점수로 라운드 마무리";
                    break;
                case 7:
                    SetTutorialLabelLayout(380, 120, 350, 100);

                    tutorialLabel.Text = "아이템\r\n상점에서 구매 가능하다\r\n최대 5개, 상점에서 제거 후 다른 아이템으로\r\n바꿀 수 있다";
                    break;
                case 8:
                    SetTutorialLabelLayout(750, 120, 200, 80);

                    tutorialLabel.Text = "디버프\r\n매 챕터 4번째 판은\r\n특별한 디버프가 적용된다";
                    break;
                case 9:
                    SetTutorialLabelLayout(900, 120, 200, 100);

                    tutorialLabel.Text = "미션\r\n매 판 미션이 두개 있다\r\n미션은 클리어 시\r\n해당 라운드 배율에\r\n반영된다";
                    break;
                case 10:
                    SetTutorialLabelLayout(850, 350, 250, 100);

                    tutorialLabel.Text = "덱\r\n자신이 추가해온 덱을 볼 수 있다\r\n현재 진행중인 판에서 사용한 카드는\r\n반전으료 표시된다\r\n*주의* 덱을 전부 사용 시 패배";
                    break;
                case 11:
                    ShowTutorialImage("튜토리얼 상점1.png");
                    break;
                case 12:
                    ShowTutorialImage("튜토리얼 상점2.png");
                    break;
                default:
                    tutorialLabel.Visible = false;
                    tutorialImage.Visible = false;

                    newbtn.Visible = true;
                    continuebtn.Visible = true;
                    tutorial.Visible = true;
                    break;
            }

            tutorialLabel.BringToFront();
        }

        private void SetTutorialLabelLayout(int x, int y, int width, int height) //튜토리얼 라벨 위치랑 사이즈 조정
        {
            tutorialLabel.Location = new Point(
                (int)(x * scaler.ScaleX),
                (int)(y * scaler.ScaleY)
            );

            tutorialLabel.Size = new Size(
                (int)(width * scaler.ScaleX),
                (int)(height * scaler.ScaleY)
            );

            tutorialLabel.BringToFront();
        }
        private void InitTutorialImage()
        {
            tutorialImage = new PictureBox();

            tutorialImage.SizeMode = PictureBoxSizeMode.Zoom;
            tutorialImage.BackColor = Color.Transparent;

            tutorialImage.Visible = false;

            tutorialImage.Click += TutorialLabel_Click;

            this.Controls.Add(tutorialImage);
        }

        private void ShowTutorialImage(string imageName)
        {
            tutorialLabel.Visible = false;

            tutorialImage.Visible = true;

            tutorialImage.Location = new Point(0, 0);

            tutorialImage.Size = this.ClientSize;

            string path = Path.Combine(
                Application.StartupPath,
                "..",
                "..",
                "Resources",
                imageName);

            tutorialImage.Image = Image.FromFile(Path.GetFullPath(path));

            tutorialImage.BringToFront();
        }

        private void ApplyCurrentTutorialLayout() //튜토리얼 단계별 사이즈 비율 조정해주는 메소드
        {
            switch (tutorialClickCount)
            {
                case 0:
                    SetTutorialLabelLayout(300, 200, 550, 300);
                    break;
                case 1:
                    SetTutorialLabelLayout(300, 140, 550, 380);
                    break;
                case 2:
                    SetTutorialLabelLayout(250, 30, 350, 190);
                    break;
                case 3:
                    SetTutorialLabelLayout(250, 120, 350, 190);
                    break;
                case 4:
                    SetTutorialLabelLayout(250, 190, 350, 120);
                    break;
                case 5:
                    SetTutorialLabelLayout(250, 300, 350, 170);
                    break;
                case 6:
                    SetTutorialLabelLayout(250, 300, 350, 320);
                    break;
                case 7:
                    SetTutorialLabelLayout(380, 120, 350, 100);
                    break;
                case 8:
                    SetTutorialLabelLayout(750, 120, 200, 80);
                    break;
                case 9:
                    SetTutorialLabelLayout(900, 120, 200, 100);
                    break;
                case 10:
                    SetTutorialLabelLayout(850, 350, 250, 100);
                    break;
            }
        }
    }
}
