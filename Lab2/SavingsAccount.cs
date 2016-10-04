using System;

namespace eu.sig.training.ch04.v1
{
    public class SavingsAccount: Account
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer makeTransfer(string counterAccount, Money amount)
        {
            // 1. Assuming result is 9-digit bank account number, validate 11-test:
            if (String.IsNullOrEmpty(counterAccount) || counterAccount.Length != 9)
            {
                throw new BusinessException("Invalid account number!");
            }
            return EatSleepCodeRepeat.AccountManager.NewMethod(counterAccount, amount, this);
        }


    }
}
