using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlackJack_TheSpire
{
    internal static class SaveManager
    {
        private static string saveFilePath = "savefile.xml";

        public static bool HasSaveFile()
        {
            return File.Exists(saveFilePath);
        }

        public static void DeleteSave()
        {
            if (File.Exists(saveFilePath))
                File.Delete(saveFilePath);
        }

        public static void Save(GameState gameState) //xml 파일 저장. 게임 저장하고 비슷함.
        {
            GameSaveData data = ConvertToSaveData(gameState);
            XmlSerializer serializer = new XmlSerializer(typeof(GameSaveData));

            using (StreamWriter writer = new StreamWriter(saveFilePath))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static GameState Load() //xml 파일 불러오기
        {
            if (!File.Exists(saveFilePath))
                return null;

            XmlSerializer serializer = new XmlSerializer(typeof(GameSaveData));
            GameSaveData data;

            using (StreamReader reader = new StreamReader(saveFilePath))
            {
                data = (GameSaveData)serializer.Deserialize(reader);
            }

            return ConvertToGameState(data);
        }

        private static GameSaveData ConvertToSaveData(GameState gameState) //세이브 데이터로 변환하기.
        {
            GameSaveData data = new GameSaveData();

            data.Seed = gameState.GetSeed();
            data.CurrentChapter = gameState.GetCurrentChapter();
            data.CurrentCycle = gameState.GetCurrentCycle();
            data.Coin = gameState.GetCoin();
            data.CycleScore = gameState.GetCycleScore();
            data.TargetScore = gameState.GetTargetScore();

            Deck deck = gameState.GetDeck();
            deck.ReturnUsedCards();
            foreach (Card card in deck.GetAllCards())
            {
                CardSaveData cardData = new CardSaveData();
                cardData.Type = (int)card.GetCardType();
                cardData.Value = (int)card.GetCardValue();
                cardData.CustomBlackjackValue = card.GetCustomBlackjackValue();
                cardData.HasCustomValue = card.HasCustomValue();
                data.Deck.Add(cardData);
            }

            foreach (Item item in gameState.GetInventory().GetItems())
            {
                data.InventoryItemIds.Add(item.Id);
            }

            return data;
        }

        private static GameState ConvertToGameState(GameSaveData data) //게임 상태로 변환하기.
        {
            GameState gameState = new GameState();

            gameState.SetSeed(data.Seed);
            gameState.SetCurrentChapter(data.CurrentChapter);
            gameState.SetCurrentCycle(data.CurrentCycle);
            gameState.SetCoin(data.Coin);
            gameState.SetCycleScore(data.CycleScore);
            gameState.SetTargetScore(data.TargetScore);

            GameRandom.SetSeed(data.Seed);

            Deck deck = gameState.GetDeck();
            deck.ClearAllCards();
            foreach (CardSaveData cardData in data.Deck)
            {
                Card card = new Card((CardType)cardData.Type, (CardValue)cardData.Value);
                if (cardData.HasCustomValue)
                    card.SetCustomBlackjackValue(cardData.CustomBlackjackValue);
                deck.AddCard(card);
            }

            foreach (int itemId in data.InventoryItemIds)
            {
                Item foundItem = ItemManager.allItems.FirstOrDefault(item => item.Id == itemId);
                if (foundItem != null)
                    gameState.AddItem(foundItem);
            }

            return gameState;
        }
    }
}