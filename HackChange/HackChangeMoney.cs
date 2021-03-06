﻿using System;

namespace HackChange
{
    public class HackChangeMoney
    {
        public ChangeModel CalculateChange(int amount, int pay)
        {
            var isWronginput = amount < 0 || pay < 0;
            var isNotEnough = pay < amount;
            if (isWronginput || isNotEnough)
            {
                return new ChangeModel
                {
                    StatusCode = isWronginput? 1 : 2,
                    Change = 0,
                    BankCards = new int[] { }
                };
            }

            var banklist = new int[] { 1000, 500, 100, 50, 20, 5, 1 };
            var change = pay - amount;
            var changebank = change;
            var banks = new int[7];

            for (int i = 0; i < banklist.Length; i++)
            {
                banks[i] = changebank / banklist[i];
                changebank = changebank % banklist[i];
            };

            return new ChangeModel
            {
                Change = change,
                BankCards = banks
            };
        }
    }
}
