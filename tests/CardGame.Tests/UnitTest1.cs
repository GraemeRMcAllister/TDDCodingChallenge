using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            //Act
            bool result = card1.Equals(card2);

            //Assert
            Debug.Assert(!result); // check for not result

        }


        [Test]
        public void Remove_IsCard_DecreasesCount()
        {
            //Arrange
            PackOfCardsCreator dealer = new PackOfCardsCreator(); 
            PackOfCards pack = new PackOfCards(dealer.Create());

            Card firstCard = new Card(Suit.Clubs, Value.Ace); // first card in deck

            //Act
            Card card = (Card)pack.TakeCardFromTopOfPack();


            //Assert
            Debug.Assert(pack.Count == 51 && card.Equals(firstCard));
        }


        [Test]
        public void ConfirmShuffleShuffles()
        {
            //Arrange
            PackOfCardsCreator dealer = new PackOfCardsCreator(); 
            PackOfCards pack = new PackOfCards(dealer.Create()); 



            //Act
            pack.Shuffle();
            Card firstCard = (Card)pack.TakeCardFromTopOfPack();
            pack.Shuffle();
            Card secondCard = (Card)pack.TakeCardFromTopOfPack();

            //Assert

            Debug.Assert(pack.Count == 51 && !firstCard.Equals(secondCard)); // first card pulled should not equal second card pulled (1/52 chance that it does based on rng)
        }

        [Test]
        public void ConfirmShuffleShuffles_ListOfCards()
        {
            //Arrange
            PackOfCardsCreator dealer = new PackOfCardsCreator(); 
            PackOfCards pack = new PackOfCards(dealer.Create()); 

            List<Card> hand1 = new List<Card>();
            List<Card> hand2 = new List<Card>();

            //Act
            pack.Shuffle();
            hand1.Add((Card)pack.TakeCardFromTopOfPack());
            hand1.Add((Card)pack.TakeCardFromTopOfPack());
            hand1.Add((Card)pack.TakeCardFromTopOfPack());

            pack.Shuffle();
            hand2.Add((Card)pack.TakeCardFromTopOfPack());
            hand2.Add((Card)pack.TakeCardFromTopOfPack());
            hand2.Add((Card)pack.TakeCardFromTopOfPack());

            //Assert

            Debug.Assert(!hand1.SequenceEqual(hand2)); // Enumerable.SequenceEqual Determines whether two sequences are equal by comparing the elements by using the default equality comparer for their type.
        }


    }
}
