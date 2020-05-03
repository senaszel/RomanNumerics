using DodawaniePoRzymsku;
using Xunit;

namespace ConRomTests
{
    public class Roman2ArabicTests
    {
        [Theory]
        [InlineData("AXV", -1)]

        [InlineData("XXV", 25)]
        [InlineData("XLIV", 44)]
        [InlineData("CXLVIII", 148)]
        [InlineData("CLIII", 153)]
        [InlineData("CDLXIII", 463)]
        [InlineData("DCCXXVII", 727)]
        [InlineData("XCV", 95)]
        [InlineData("LXV", 65)]
        [InlineData("CCXLV", 245)]
        [InlineData("CDXCVII", 497)]
        [InlineData("CMXCII", 992)]

        [InlineData("CMXCIX", 999)]
        [InlineData("I", 1)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        [InlineData("XC", 90)]
        [InlineData("C", 100)]
        [InlineData("CD", 400)]
        [InlineData("D", 500)]
        [InlineData("CM", 900)]
        [InlineData("M", 1000)]
        public static void Roman2Arabic_Should_Return_ArabicNumber(string romanNumber, int arabNumber)
        {
            //arrange

            //act
            int actual = Program.Roman2Arabic(romanNumber);

            //assert
            Assert.Equal(arabNumber, actual);
        }
    }
}
