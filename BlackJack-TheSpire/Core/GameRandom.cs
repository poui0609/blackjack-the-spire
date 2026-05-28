using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    internal static class GameRandom //랜덤이 계속되면 안됨. 하나의 값을 공유해야함. 시드.
    {
        private static Random random = new Random(); //난수 생성
        private static int currentSeed; //현재 사용중인 시드
        private static int callCount; //난수를 몇 번 꺼냈는지 세는 카운터. 시드 재현용

        public static int GetCurrentSeed() //시드가져오는거
        {
            return currentSeed;
        }

        public static int GetCallCount() //난수 호출 횟수 가져오는거. 저장할 때 씀
        {
            return callCount;
        }

        public static void SetSeed(int seed) // 시드 생성기. seed 값에 맞는 시드로 생성함.
        {
            currentSeed = seed;
            random = new Random(seed);
            callCount = 0; //시드 새로 설정하면 난수 위치도 처음으로 돌아가니까 카운터도 0
        }

        public static void SetRandomSeed() // 시드생성기2 시드 안가져오고 자동으로 만들때 사용.
        {
            currentSeed = Environment.TickCount;
            random = new Random(currentSeed);
            callCount = 0;
        }

        public static void Restore(int seed, int count) //로드할 때 씀. 시드 맞추고 저장된 횟수만큼 난수 헛돌려서 위치 맞춤
        {
            currentSeed = seed;
            random = new Random(seed);
            callCount = 0;

            for (int i = 0; i < count; i++) //저장 시점까지 난수 시퀀스를 전진시킴
            {
                random.Next(); //래퍼 안쓰고 직접 돌림. 안그러면 callCount가 이중으로 올라감
                callCount++;
            }
        }


        /*
         * 래핑
         * 난수 값을 우리가 임의 지정하게 하려고 씀
         * 기본 랜덤 클래스의 next와 같음
         * 이제 호출할 때마다 callCount가 올라감
         */
        public static int Next(int maxValue)
        {
            callCount++; //난수 꺼낼 때마다 카운터 증가
            return random.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            callCount++;
            return random.Next(minValue, maxValue);
        }

        public static double NextDouble()
        {
            callCount++;
            return random.NextDouble();
        }
    }
}