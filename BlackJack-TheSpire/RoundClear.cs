using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack_TheSpire.Scaler;

namespace BlackJack_TheSpire
{
    internal partial class RoundClear : Form
    {
        private FormScaler scaler;
        public RoundClear(GameState gameState, int cycle, int score, int targetScore, int earnedCoin)
        {
            InitializeComponent();

            scaler = new FormScaler(this);

            lblRound.Text = $"{gameState.GetCurrentChapter()}-{gameState.GetCurrentCycle()}";
            lblScore.Text = score + "점 / " + targetScore + "점";
            lblCoin.Text = "+" + earnedCoin;

            string detail = "";
            List<int> scores = gameState.GetRoundScores();

            for(int i = 0; i < 4; i++)
            {
                int roundScore = 0;
                if (i < scores.Count)
                {
                    roundScore = scores[i];
                }
                detail += $"{i + 1}판: {roundScore}점\n";
            }
            lblRoundDetail.Text = detail;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
