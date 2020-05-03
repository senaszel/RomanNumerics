using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DodawaniePoRzymsku;

namespace ConRomTests
{
    public class ConRomTests
    {

        [Theory]
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
        public static void ConRom_Should_Return_RomanNumber(int arab, string roman)
        {
            //arrenge

            //act
            string actual = Program.Convert2Roman(arab);

            //assert
            Assert.Equal(roman, actual);
        }
    }
}
