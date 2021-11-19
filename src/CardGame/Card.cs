using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.CardGame
{
    class Card : ICard
    {
        public Suit Suit => throw new NotImplementedException();

        public Value Value => throw new NotImplementedException();

        public bool Equals(ICard other) => throw new NotImplementedException();
    }
}
