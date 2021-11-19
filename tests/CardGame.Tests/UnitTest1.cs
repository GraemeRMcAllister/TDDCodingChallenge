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
            Debug.Assert(pack.Count == 52);


        }


    }
}
