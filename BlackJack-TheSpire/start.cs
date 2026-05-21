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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }
        internal GameState SelectedGameState { get; private set; }
        private void newbtn_Click(object sender, EventArgs e)
        {
            GameRandom.SetRandomSeed();

            SelectedGameState = new GameState(); //새로운 저장정보

            RoundManager roundManager = new RoundManager(SelectedGameState);
            CycleManager cycleManager = new CycleManager(SelectedGameState, roundManager);
            cycleManager.StartCycle();
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
