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

        public static int GetCurrentSeed() //시드가져오는거
        {
            return currentSeed;
        }

        public static void SetSeed(int seed) // 시드 생성기. seed 값에 맞는 시드로 생성함.
        {
            currentSeed = seed;
            random = new Random(seed);
        }

        public static void SetRandomSeed() // 시드생성기2 시드 안가져오고 자동으로 만들때 사용.
        {
            currentSeed = Environment.TickCount;
            random = new Random(currentSeed);
        }


        /*
         * 래핑
         * 난수 값을 우리가 임의 지정하게 하려고 씀
         * 기본 랜덤 클래스의 next와 같음
         * 
         */
        public static int Next(int maxValue)
        {
            return random.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        public static double NextDouble()
        {
            return random.NextDouble();
        }
    }
}