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

        public static void Save(GameState gameState)
        {
            GameSaveData data = ConvertToSaveData(gameState);
            XmlSerializer serializer = new XmlSerializer(typeof(GameSaveData));

            using (StreamWriter writer = new StreamWriter(saveFilePath))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static GameState Load()
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

        private static GameSaveData ConvertToSaveData(GameState gameState)
        {
            GameSaveData data = new GameSaveData();

            data.Seed = gameState.GetSeed();
            data.CurrentChapter = gameState.GetCurrentChapter();
            data.CurrentCycle = gameState.GetCurrentCycle();
            data.CurrentRound = gameState.GetCurrentRound();
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

        private static GameState ConvertToGameState(GameSaveData data)
        {
            GameState gameState = new GameState();

            gameState.SetSeed(data.Seed);
            gameState.SetCurrentChapter(data.CurrentChapter);
            gameState.SetCurrentCycle(data.CurrentCycle);
            gameState.SetCurrentRound(data.CurrentRound);
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