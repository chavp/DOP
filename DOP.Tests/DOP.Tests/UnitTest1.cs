using DOP.Tests.Datas;
using DOP.Tests.Funcs;
using DOP.Tests.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DOP.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAuthor()
        {
            var sugoku = new Author { FirstName = "Sun", LastName = "Goku", Books = 101 };
            System.Console.WriteLine($"Fullname: {sugoku.FullName}");
            System.Console.WriteLine($"IsProlific: {sugoku.IsProlific}");

            Assert.AreEqual("Sun Goku", sugoku.FullName);
            Assert.AreEqual(true, sugoku.IsProlific);
        }

        [TestMethod]
        public void TestAuthorData()
        {
            var sugoku = new AuthorData { FirstName = "Sun", LastName = "Goku", Books = 101 };
            System.Console.WriteLine($"Fullname: {sugoku.FullName()}");
            System.Console.WriteLine($"IsProlific: {sugoku.IsProlific()}");

            Assert.AreEqual("Sun Goku", NameCalculation.FullName(sugoku));
            Assert.AreEqual(true, AuthorRating.IsProlific(sugoku));
        }

        [TestMethod]
        public void TestAccount()
        {
            var acc = new Account { Balance = 1000 };
            System.Console.WriteLine($"Balance: {acc.Balance}");
            acc.Withdraw(100);
            System.Console.WriteLine($"Withdraw(100) - Balance: {acc.Balance}");
            acc.Deposit(1000);
            System.Console.WriteLine($"Deposit(1000) - Balance: {acc.Balance}");

            Assert.AreEqual(1900, acc.Balance);
        }

        [TestMethod]
        public void TestAccountData()
        {
            var acc = new AccountData { Balance = 1000 };
            System.Console.WriteLine($"Balance: {acc.Balance}");
            var acc1 = acc.Withdraw(100);
            System.Console.WriteLine($"Withdraw(100) - Balance: {acc1.Balance}");
            var acc2 = acc1.Deposit(1000);
            System.Console.WriteLine($"Deposit(1000) - Balance: {acc2.Balance}");

            Assert.AreEqual(1900, acc2.Balance);
        }
    }

}
