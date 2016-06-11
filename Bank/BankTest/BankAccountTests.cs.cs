using System;
using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double beginningBanlance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBanlance);

            account.Debit(debitAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }


        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningBanlance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBanlance);

            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        public void Debit_WhenAmountIsGreaterThanBanlance_ShouleThrowArgumentOutOfRange()
        {
            double beginningBanlance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBanlance);

            try
            {
                account.Debit(debitAmount);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            double beginningBanlance = 10.11;
            double creditAmount = 23.19;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBanlance);

            account.Credit(creditAmount);

            double actual = 33.30;
            Assert.AreEqual(account.Balance, actual, 0.001, "Account not credit correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningBanlance = 12.43;
            double creditAmount = -10;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBanlance);

            account.Credit(creditAmount);
        }
    }
}
