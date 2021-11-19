using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; }

        public Value Value { get; }

        public bool Equals(ICard other)
        {
            return Value == other.Value && Suit == other.Suit;
        }
    }
}
