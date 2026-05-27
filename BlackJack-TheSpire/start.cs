using BlackJack_TheSpire.Scaler;
using System;
using System.Windows.Forms;

namespace BlackJack_TheSpire
{
    public partial class start : Form
    {
        FormScaler scaler;

        public start()
        {
            InitializeComponent();

            scaler = new FormScaler(this);
        }

        internal GameState SelectedGameState { get; private set; }

        private void newbtn_Click(object sender, EventArgs e)
        {
            GameRandom.SetRandomSeed();

            SelectedGameState = new GameState(); //새로운 저장정보

            SelectedGameState.GetDeck().Shuffle();
            RoundManager roundManager = new RoundManager(SelectedGameState);
            CycleManager cycleManager = new CycleManager(SelectedGameState, roundManager);
            SaveManager.Save(SelectedGameState); //새로운 정보로 저장

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void loading_Click(object sender, EventArgs e)
        {
            if (!SaveManager.HasSaveFile())
            {
                MessageBox.Show("저장 파일이 없습니다.");
                return;
            }

            SelectedGameState = SaveManager.Load(); //기존정보 불러오기

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}