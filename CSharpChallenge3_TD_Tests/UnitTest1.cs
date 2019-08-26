using System;
using CSharpChallenge3_TD;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CSharpChallenge3_TD_Tests
{
    [TestClass]
    public class Tester
    {
        private double epsilon = 1e-6;

        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            //arrange
            Account account = new Account(-20);

            //act           
            var account_actual = account.OverdraftLimit;

            //assert        
            //    Assert.AreEqual(aexpected, account_actual);
            Assert.IsTrue(account_actual > 0, "Negative Balance");
            //Assert.That(account_actual, Is.GreaterThan(0));


        }
    }
}
