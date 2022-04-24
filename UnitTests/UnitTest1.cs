using DebitCredit;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTests
    {
        [Fact]
        public void DebitCredit_ValidDebit()
        {
            //Arrange
            Account account = new Account(50000.00);

            //Act
            int validate = account.debitBalance(15000.00);

            //Assert
            Assert.Equal(1, validate);
        }

        [Fact]
        public void DebitCredit_InvalidDebitWithAmount0()
        {
            //Arrange
            Account account = new Account(50000.00);

            //Act
            int validate = account.debitBalance(0);

            //Assert
            Assert.Equal(0, validate);
        }

        [Fact]
        public void DebitCredit_InvalidDebitWithASuperiorAmount()
        {
            //Arrange
            Account account = new Account(50000.00);

            //Act
            int validate = account.debitBalance(75000.00);

            //Assert
            Assert.Equal(0, validate);
        }

        [Fact]
        public void DebitCredit_ValidCredit()
        {
            //Arrange
            Account account = new Account(50000.00);

            //Act
            int validate = account.creditBalance(15000.00);

            //Assert
            Assert.Equal(1, validate);
        }

        [Fact]

        public void DebitCredit_InvalidCredit()
        {
            //Arrange
            Account account = new Account(50000.00);

            //Act
            int validate = account.creditBalance(0);

            //Assert
            Assert.Equal(0, validate);
        }
    }
}
