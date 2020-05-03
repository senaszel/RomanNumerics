using Xunit;
using DodawaniePoRzymsku;

namespace ConRomTests
{
    public class Arabic2RomanTests
    {
        [Theory]
        [InlineData(19, "XIX")]//celowo bledny
        [InlineData(25, "XXV")]
        [InlineData(44, "XLIV")]
        [InlineData(148, "CXLVIII")]
        [InlineData(153, "CLIII")]
        [InlineData(463, "CDLXIII")]
        [InlineData(727, "DCCXXVII")]
        [InlineData(95, "XCV")]
        [InlineData(65, "LXV")]
        [InlineData(245, "CCXLV")]
        [InlineData(497, "CDXCVII")]
        [InlineData(992, "CMXCII")]
        [InlineData(999, "CMXCIX")]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(90, "XC")]
        [InlineData(100, "C")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        public static void Arabic2Roman_Should_Return_RomanNumeral(int arab, string roman)
        {
            //arrange

            string actual = Program.Arabic2Roman(arab);

            //assert
            Assert.Equal(roman, actual);

        }
    }
}
