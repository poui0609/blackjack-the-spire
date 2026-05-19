using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class RoundManager
    {
        private GameState gameState;
        private Hand playerHand;
        private bool isRoundOver;
        private bool isFolded;

        public RoundManager(GameState gameState)
        {
            this.gameState = gameState;
            playerHand = new Hand();
            isRoundOver = false;
            isFolded = false;
        }

        public Hand GetPlayerHand()
        {
            return playerHand;
        }

        public bool IsRoundOver()
        {
            return isRoundOver;
        }

        public bool IsFolded()
        {
            return isFolded;
        }

        public void StartRound()
        {
            playerHand.Clear();
            isRoundOver = false;
            isFolded = false;
        }

        public Card Draw()
        {
            if (isRoundOver) return null;

            Card drawn = gameState.GetDeck().Draw();
            playerHand.AddCard(drawn);

            if (playerHand.IsBust())
            {
                EndRound();
            }
            return drawn;
        }

        public void Stand()
        {
            if (isRoundOver) return;

            EndRound();
        }

        public bool Fold()
        {
            if (gameState.GetCycleScore() <= 0) return false;

            int penalty = gameState.GetCycleScore() / 2;
            gameState.SetCycleScore(gameState.GetCycleScore() - penalty);
            playerHand.Clear();
            isFolded = true;
            return true;
        }

        private void EndRound()
        {
            isRoundOver = true;

            if (!isFolded)
            {
                int score = ScoreCalculator.CalculateScore(playerHand);
                gameState.AddCycleScore(score);
            }
        }

        public int GetLastRoundScore()
        {
            if (isFolded) return 0;
            return ScoreCalculator.CalculateScore(playerHand);
        }

        public bool CanFold()
        {
            return !isRoundOver && gameState.GetCycleScore() > 0;
        }
    }
}