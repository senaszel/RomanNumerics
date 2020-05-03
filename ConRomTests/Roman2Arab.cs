using DodawaniePoRzymsku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConRomTests
{
    public class Roman2Arab
    {
        [Theory]
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
        public static void Roman2Arab_Should_Return_ArabNumber(string romanNumber, int arabNumber)
        {
            //arrange

            //act
            int actual = Program.Roman2Arab(romanNumber);

            //assert
            Assert.Equal(arabNumber, actual);
        }
    }
}
