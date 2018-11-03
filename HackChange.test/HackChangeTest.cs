using System;
using Xunit;

namespace HackChange.test
{
    public class HackChangeTest
    {
        [Theory]
        [InlineData(648, new int[7] { 0, 1, 1, 0, 2, 1, 3 }, 352, 1000)]
        [InlineData(350, new int[7] { 0, 0, 3, 1, 0, 0, 0 }, 650, 1000)]
        public void InputAmountAndPayReturnChangeAndBank(int expectedChange, int[] expectedBankCards, int amount, int pay)
        {
            var hackChangeMoney = new HackChangeMoney();
            var result = hackChangeMoney.CalculateChange(amount, pay);
            Assert.Equal(expectedChange, result.Change);
            Assert.Equal(expectedBankCards, result.BankCards);
        }
    }
}
