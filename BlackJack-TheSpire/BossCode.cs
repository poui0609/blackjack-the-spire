using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_TheSpire
{
    // 1. 보스 객체를 정의하는 클래스 (기존 Item 클래스와 유사한 구조)
    internal class Boss
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        // 아이템과 동일하게 게임 상태, 핸드, 배율을 받아 디버프가 적용된 최종 배율을 반환합니다.
        // ※ GameState, Hand 클래스 이름은 프로젝트에 구현된 실제 클래스명으로 맞춰주세요.
        public Func<GameState, Hand, double, double> Effect { get; private set; }

        public Boss(int id, string name, string description, Func<GameState, Hand, double, double> effect)
        {
            Id = id;
            Name = name;
            Description = description;
            Effect = effect;
        }
    }

    // 2. 보스 리스트와 랜덤 뽑기 기능을 관리하는 클래스
    internal static class BossManager
    {
        public static List<Boss> allBosses = new List<Boss>()
        {
            // 보스 번호, 보스 이름, 설명, 효과 적용 (주로 배율 감소나 조건부 페널티)
            new Boss(1, "탐욕의 딜러", "최종 점수 배율 x0.8", 
                (gameState, hand, multiplier) => { return multiplier * 0.8; }),
                
            new Boss(2, "압박감", "카드 5장 이상 뽑을 시 배율 x0.5", 
                (gameState, hand, multiplier) => { if (hand.GetCardCount() >= 5) return multiplier * 0.5; return multiplier; }),
                
            new Boss(3, "침묵의 족쇄", "Ace 카드 포함 시 배율 x0.8", 
                (gameState, hand, multiplier) => { 
                    // CardValue.Ace 부분은 프로젝트의 실제 enum 명칭에 맞게 수정해주세요.
                    bool hasAce = hand.GetCards().Any(card => card.GetCardValue() == CardValue.Ace); 
                    if (hasAce) return multiplier * 0.8; 
                    return multiplier; 
                }),
                
            new Boss(4, "시간 제한", "첫 사이클은 배율 x0.5", 
                (gameState, hand, multiplier) => { if (gameState.GetCurrentCycle() == 1) return multiplier * 0.5; return multiplier; }),
                
            new Boss(5, "완벽주의자", "카드 합 20 미만 시 배율 x0.7", 
                (gameState, hand, multiplier) => { if (hand.CalculateValue() < 20) return multiplier * 0.7; return multiplier; })
        };

        // 보스를 랜덤으로 뽑는 메소드
        public static Boss GetRandomBoss()
        {
            // ItemManager에 있는 GameRandom을 동일하게 사용
            int index = GameRandom.Next(allBosses.Count);
            return allBosses[index];
        }
    }
}