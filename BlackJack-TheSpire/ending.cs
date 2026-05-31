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
    internal partial class ending : Form
    {
        public ending(GameState gamestate)
        {
            InitializeComponent();
            this.gamestate = gamestate;

            scaler = new FormScaler(this);
        }

        GameState gamestate;
        private FormScaler scaler;

        private void deck_Click(object sender, EventArgs e)
        {
            HaveDeck haveDeck = new HaveDeck(gamestate, 1);
            haveDeck.ShowDialog();
        }

        private void ending_Shown(object sender, EventArgs e)
        {
            scaler.ApplyScale();

            if (gamestate.IsGameClear())
            {
                result.Text = "클리어!";
                roundlbl.Visible = false;
            }
            else
            {
                result.Text = "패배...";
                roundlbl.Text = $"{gamestate.GetCurrentChapter()}-{gamestate.GetCurrentCycle()}";
            }
            ShowItemList();
        }

        private void ShowItemList()
        {
            itemlbl.Text = "아이템 목록\r\n";

            foreach (Item item in gamestate.GetInventory().GetItems())
            {
                itemlbl.Text += $"{item.Name} - {item.Description}\r\n";
            }
        }
    }
}
