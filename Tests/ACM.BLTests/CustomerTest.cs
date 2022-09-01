using ACM.BL;
using Xunit;

namespace ACM.BLTests
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValide()
        {
            //-- Arrange
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            var expected = "Baggins, Bilbo";

            //-- Act
            var actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };

            var expected = "Baggins";

            //-- Act
            var actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullNameLasttNameEmpty()
        {
            //-- Arrange
            var customer = new Customer
            {
                FirstName = "Bilbo"
            };

            var expected = "Bilbo";

            //-- Act
            var actual = customer.FullName;

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StaticTest()
        {
            //-- Arrange 
            var c1 = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Frodo"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Rosie"
            };
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void ValidateValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Baggins",
                LastName = "fbaggins@hobbiton.com"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Baggins"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}