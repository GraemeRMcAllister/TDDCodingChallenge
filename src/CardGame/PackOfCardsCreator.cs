using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {

            List<Card> deck = new List<Card>();

            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value v in Enum.GetValues(typeof(Value))) // 2d loop of suit and value. Ensures unique entries and matched count with enums
                {
                    deck.Add(new Card(s, v));
                }
            }

            return new PackOfCards(deck);

        }
    }
}
