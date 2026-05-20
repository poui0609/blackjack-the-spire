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

        public void StartCycle() //사이클 시작
        {
            gameState.ResetCycleScore();
            gameState.SetCurrentRound(1);

            /*if (gameState.GetCurrentCycle() <= 2)
            {
                gameState.SetTargetScore(60); // 하드코딩 되어있길래 일단 주석처리함
                                              // 일단 점수 설정은 현빈씨가 해야함
            }
            else
            {
                gameState.SetTargetScore(80);
            }*/

            isCycleOver = false;
            isCycleSuccess = false;

            gameState.SetCurrentMissions(MissionManager.GetRandomMissions(2)); //사이클 시작시 미션 랜덤 생성

            gameState.GetDeck().ReturnUsedCards();
            gameState.GetDeck().Shuffle();

            roundManager.StartRound();
        }

        public void OnRoundEnd() //라운드 끝날 때마다 이거 호출해서 사이클 끝났는지 체크
        {
            if (gameState.IsTargetReached()) //목표점수 달성했는지 체크
            {
                int reward = gameState.CalculateCycleReward();
                gameState.AddCoin(reward); 
                isCycleSuccess = true;
                isCycleOver = true;
                return;
            }

            if (gameState.GetCurrentRound() >= 4) //4라운드 끝났는데 목표점수 못달성했으면 사이클 실패
            {
                isCycleSuccess = false;
                isCycleOver = true;
                isGameOver = true;
                return;
            }

            gameState.NextRound();
            roundManager.StartRound();
        }

        public void GoToNextCycle() //다음 사이클 가는거
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