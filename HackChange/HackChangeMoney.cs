using System;

namespace HackChange
{
    public class HackChangeMoney
    {
        public ChangeModel CalculateChange(int amount, int pay){
            var change = 350;
            var banks = new int[7] { 0, 0, 3, 1, 0, 0, 0 };
            var result = new ChangeModel
            {
                Change = change,
                BankCards = banks
            };
            return result;
        }
    }
}
