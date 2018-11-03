using System;

namespace HackChange
{
    public class HackChangeMoney
    {
        public ChangeModel CalculateChange(int amount, int pay)
        {
            var change = pay - amount;
            var changebank = change;
            var banks = new int[7];
            banks[0] = changebank / 1000;
            changebank = changebank % 1000;
            banks[1] = changebank / 500;
            changebank = changebank % 500;
            banks[2] = changebank / 100;
            changebank = changebank % 100;
            banks[3] = changebank / 50;
            changebank = changebank % 50;
            banks[4] = changebank / 20;
            changebank = changebank % 20;
            banks[5] = changebank / 5;
            changebank = changebank % 5;
            banks[6] = changebank / 1;
            changebank = changebank % 1;
            var result = new ChangeModel
            {
                Change = change,
                BankCards = banks
            };
            return result;
        }
    }
}
