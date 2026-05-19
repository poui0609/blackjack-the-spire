using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal class CycleManager
    {
        private GameState gameState;
        private RoundManager roundManager;
        private bool isCycleOver;
        private bool isCycleSuccess;
        private bool isGameOver;

        public CycleManager(GameState gameState, RoundManager roundManager)
        {
            this.gameState = gameState;
            this.roundManager = roundManager;
            isCycleOver = false;
            isCycleSuccess = false;
            isGameOver = false;
        }

        public bool IsCycleOver()
        {
            return isCycleOver;
        }

        public bool IsCycleSuccess()
        {
            return isCycleSuccess;
        }

        public bool IsGameOver()
        {
            return isGameOver;
        }

        public void StartCycle()
        {
            gameState.ResetCycleScore();
            gameState.SetCurrentRound(1);
            isCycleOver = false;
            isCycleSuccess = false;

            gameState.GetDeck().ReturnUsedCards();
            gameState.GetDeck().Shuffle();

            roundManager.StartRound();
        }

        public void OnRoundEnd()
        {
            if (gameState.IsTargetReached())
            {
                int reward = gameState.CalculateCycleReward();
                gameState.AddCoin(reward);
                isCycleSuccess = true;
                isCycleOver = true;
                return;
            }

            if (gameState.GetCurrentRound() >= 4)
            {
                isCycleSuccess = false;
                isCycleOver = true;
                isGameOver = true;
                return;
            }

            gameState.NextRound();
            roundManager.StartRound();
        }

        public void GoToNextCycle()
        {
            gameState.NextCycle();

            if (gameState.IsGameClear())
            {
                isGameOver = true;
                return;
            }

            StartCycle();
        }
    }
}