using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReverseStringUnitTests
    {
        [Test]
        [TestCase("SonnyJim", "miJynnoS")]
        [TestCase("Peace", "ecaeP")]
        [TestCase("FooBazQux", "xuQzaBooF")]
        [TestCase("Hello Bar", "raB olleH")]
        public void ShouldReverse(string input, string expectedResult)
        {
            //Arrange
            // TestCase parameters 

            //Act
            string output = StringUtilities.Reverse(input);

            //Assert
            Assert.AreEqual(expectedResult, output);

        }


        [Test]
        public void SingleLetterNoChange()
        {
            //Arrange
            string input = "A";
            string expectedResult = "A";

            //Act
            string output = StringUtilities.Reverse(input);

            //Assert
            Assert.AreEqual(expectedResult, output);

        }


        [Test]
        public void RandomCharacterReverse()
        {
            //Arrange
            string input = "c/.]'a./3W]2#-=RaSF]al,2f=-12lfa.fas.f";
            string expectedResult = "f.saf.afl21-=f2,la]FSaR=-#2]W3/.a']./c";

            //Act
            string output = StringUtilities.Reverse(input);

            //Assert
            Assert.AreEqual(expectedResult, output);

        }

        [Test]
        public void ReverseNumeric()
        {
            //Arrange
            string input = "012345678";
            string expectedResult = "876543210";

            //Act
            string output = StringUtilities.Reverse(input);

            //Assert
            Assert.AreEqual(expectedResult, output);

        }

    }
}