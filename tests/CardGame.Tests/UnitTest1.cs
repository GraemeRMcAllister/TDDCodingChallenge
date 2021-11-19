using System.Diagnostics;
using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void BasicTest()
        {
            //Arrange
            PackOfCardsCreator dealer = new PackOfCardsCreator(); // create POCcreator object to call create method
            PackOfCards pack = new PackOfCards(dealer.Create()); // create POC object that has access/holds a deck -- pass created deck as constructor?


            //Act
            pack.TakeCardFromTopOfPack();   
            pack.Shuffle();

            //Assert
            Debug.Assert(pack.Count == 52);
        }

        [Test]
        [TestCase(Suit.Clubs,Value.Eight, Suit.Clubs, Value.Eight)] // same card
        [TestCase(Suit.Spades, Value.Ace, Suit.Spades, Value.Ace)] // same card
        public void CompareCardsIsSame(Suit card1Suit, Value card1Value, Suit card2Suit, Value card2Value)
        {
            //Arrange
            Card card1 = new Card(card1Suit, card1Value);
            Card card2 = new Card(card2Suit, card2Value);

            bool result = card1.Equals(card2);


            Debug.Assert(result);

        }

        [Test]
        [TestCase(Suit.Clubs, Value.Eight, Suit.Clubs, Value.Nine)] // Single card value different
        [TestCase(Suit.Hearts, Value.Eight, Suit.Clubs, Value.Eight)] // Single Suit different
        [TestCase(Suit.Hearts, Value.Eight, Suit.Clubs, Value.Ten)] // Different Suit+Value
        public void CompareCardsIsDiffernt(Suit card1Suit, Value card1Value, Suit card2Suit, Value card2Value)
        {
            //Arrange
            Card card1 = new Card(card1Suit, card1Value);
            Card card2 = new Card(card2Suit, card2Value);


            bool result = card1.Equals(card2);

            Debug.Assert(!result); // check for not result

        }


    }
}
