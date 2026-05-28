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

        public Hand GetPlayerHand() //핸드 가져오기
        {
            return playerHand;
        }

        public bool IsRoundOver()
        {
            return isRoundOver;
        }

        public bool IsFolded() //폴드했을때
        {
            return isFolded;
        }

        public void StartRound() //라운드 시작. 사이클이랑 다름
        {
            playerHand.Clear();
            isRoundOver = false;
            isFolded = false;
        }

        public Card Draw() //카드 뽑기
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

        public void Stand() //스탠드 하면 이거 가져오면 됨
        {
            if (isRoundOver) return;

            EndRound();
        }

        public bool Fold() //폴드
        {
            if (gameState.GetCycleScore() <= 0) return false;

            int penalty = gameState.GetCycleScore() / 2;
            gameState.SetCycleScore(gameState.GetCycleScore() - penalty);
            playerHand.Clear();
            isFolded = true;
            return true;
        }

        private void EndRound() //라운드 종료
        {
            isRoundOver = true;
            if (!isFolded)
            { 
                int score = ScoreCalculator.CalculateScore(playerHand, gameState);           //라운드 끝나고 미션 성공시 배율 적용하는 곳
                gameState.AddCycleScore(score);
            }
        }

        public int GetLastRoundScore() //마지막 라운드 점수 가져오기
        {
            if (isFolded) return 0;
            return ScoreCalculator.CalculateScore(playerHand, gameState);
        }

        public bool CanFold() //폴드 가능한지 여부
        {
            return !isRoundOver && gameState.GetCycleScore() > 0;
        }
    }
}