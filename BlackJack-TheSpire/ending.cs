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
    internal partial class ending : Form
    {
        public ending(GameState gamestate)
        {
            InitializeComponent();
            this.gamestate = gamestate;
        }
        GameState gamestate;
        private void deck_Click(object sender, EventArgs e)
        {
            HaveDeck haveDeck = new HaveDeck(gamestate);
            haveDeck.ShowDialog();
        }

        private void ending_Shown(object sender, EventArgs e)
        {
            if (gamestate.IsGameClear())
            {
                result.Text = "클리어!";
            }
            else
            {
                result.Text = "패배...";
            }
            scorelbl.Text = $"점수: {gamestate.GetCycleScore()}";
            goalscorelbl.Text = $"목표점수: {gamestate.GetTargetScore()}";
        }
    }
}
