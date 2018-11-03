using System;
using Xunit;

namespace HackChange.test
{
    public class HackChangeTest
    {
        [Fact]
        public void InputAmountAndPayReturnChangeAndBank()
        {
            var hackChangeMoney = new HackChangeMoney();
            var result = hackChangeMoney.CalculateChange(650, 1000);
            Assert.Equal(350, result.Change);
            Assert.Equal(new int[7] { 0, 0, 3, 1, 0, 0, 0 }, result.BankCards);
        }

        [Fact]
        public void InputAmountAndPayReturnChangeAndBank2()
        {
            var hackChangeMoney = new HackChangeMoney();
            var result = hackChangeMoney.CalculateChange(352, 1000);
            Assert.Equal(648, result.Change);
            Assert.Equal(new int[7] { 0, 0, 3, 1, 0, 0, 0 }, result.BankCards);
        }
    }
}
