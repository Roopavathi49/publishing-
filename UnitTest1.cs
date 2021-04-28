using BankStaff;
using System;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);

        }
        [Fact]
        public void Test2()
        {
            var account = new BankAccount("kendra", 10000);
            Assert.Throws<InvalidOperationException>(() =>account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw"));
            try
            {
                account.MakeWithdrawal(8000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }


            //try
            //{
            //    account.MakeWithdrawal(50, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
        }
        [Fact]
        public void Test3()
        {
            //try
            //{
            //    var invalidAccounnt = new BankAccount("invalid", -55);
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative");
            //    Console.WriteLine(e.ToString());
            //}
            Assert.Throws<ArgumentOutOfRangeException>( ()=>  new BankAccount("invalid", -55));

        }
    }
}
