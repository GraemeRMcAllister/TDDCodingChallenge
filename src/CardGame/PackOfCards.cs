using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {


        private IPackOfCardsCreator _packOfCardsCreator = new PackOfCardsCreator(); // This ideally would be DI 

        private IReadOnlyCollection<ICard> _deck;
        public PackOfCards(IReadOnlyCollection<ICard> deck) // accepts deck in constructor Collection of <Card>
        {
            _deck = deck;
        }
        public int Count
        {
            get
            {
                return _deck.Count;
            }
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return _deck.GetEnumerator();
        }

        public void Shuffle() // Functionality matches creating a new deck before shuffle, used creator rather thatn duplicating code. note: shuffle could probably be in a seperate class 
        {
            Random rng = new Random();
            _deck = _packOfCardsCreator.Create().OrderBy(item => rng.Next()).ToList(); // Creator creats new deck ICollection implementes IList so OrderBy can be used on a random int as order. As ICard implentes ICollection, don't need AsReadOnly etc.
        }


        public ICard TakeCardFromTopOfPack()
        {
            Card card;

            try
            {
                card = (Card)_deck.First();    // same functionallity in try catch to prevent any InvalidOperationException (empty sequence) 

                List<ICard> DeckList = _deck.ToList();

                DeckList.Remove(card);

                _deck = DeckList;

            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine(ex.Message);
                System.Console.WriteLine("No card in deck - returning null card");
                card = null;
            }

            return card;


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
