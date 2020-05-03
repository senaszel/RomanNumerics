using DodawaniePoRzymsku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConRomTests
{
    public class SumTests
    {

        [Theory]
        [InlineData("X","X",20 )]
        [InlineData("CMLXXXI", "IV", 985)]
        [InlineData("DCLV", "DCL", 1305)]
        [InlineData("CCXXVIII", "LXI", 289)]
        [InlineData("CCXLVII", "DLXX",817)]
        [InlineData("DCCVIII", "DCCCLIII",1561)]
        [InlineData("CMXXIII", "DCCCXXI",1744)]
        public static void Sum_Should_Return_SumOf2RomanNumbersAsArabicNumber(string rn1,string rn2,int arabicNb)
        {
            //arrange
            //act
            int actual = Program.Roman2Arab(Program.Sum(rn1, rn2));

            //assert
            Assert.Equal(arabicNb, actual);
        }

    }
}
