using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, int> powerOfCards = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                powerOfCards.Add(i.ToString(), i);
            }
            powerOfCards.Add("J", 11);
            powerOfCards.Add("Q", 12);
            powerOfCards.Add("K", 13);
            powerOfCards.Add("A", 14);
            Dictionary<string, int> typeOfCards = new Dictionary<string, int>();
            typeOfCards.Add("S", 4);
            typeOfCards.Add("H", 3);
            typeOfCards.Add("D", 2);
            typeOfCards.Add("C", 1);
            Dictionary<string, int> allCardsValues = new Dictionary<string, int>();
            foreach (var card in powerOfCards)
            {
                foreach (var type in typeOfCards)
                {
                    allCardsValues.Add(card.Key + type.Key, card.Value * type.Value);
                }
            }
            Dictionary<string, string> playersAndCards = new Dictionary<string, string>();
            string cards = "";
            string person = "";
            while (input != "JOKER")
            {
                string[] personsWithCards = input.Split(':').ToArray();
                person = personsWithCards[0];
                cards = personsWithCards[1];
                string oldCards = "";
                if (playersAndCards.ContainsKey(person))
                {
                    
                    playersAndCards.TryGetValue(person,out oldCards);
                    playersAndCards.Remove(person);
                }
                playersAndCards.Add(person, cards+oldCards);
                input = Console.ReadLine();
            }
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var player in playersAndCards)
            {
                string[] cardsPerPlayer = player.Value.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
                int value = 0;
                int sum = 0;

                foreach (var card in cardsPerPlayer)
                {
                    allCardsValues.TryGetValue(card, out value);
                    sum += value;
                }
                result.Add(player.Key, sum);
            }

            foreach (var player in result)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }
}
