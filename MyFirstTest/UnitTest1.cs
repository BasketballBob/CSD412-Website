using System;
using Xunit;
using MVCWebApp;
using MVCWebApp.Models;

namespace MyFirstTest
{
    public class UnitTest1
    {
       
        [Fact]
        public void CustomerModelFactTest()
        {
            CustomerModel testCustomer = new CustomerModel();
            testCustomer.FirstName = "First";
            testCustomer.LastName = "Last";
            Assert.True(testCustomer.FirstName != testCustomer.LastName);
        }

        [Theory]
        [InlineData("Michael", "Green")]
        public void CustomerModelTheoryTest(string firstName, string lastName)
        {
            CustomerModel testCustomer = new CustomerModel();
            testCustomer.FirstName = firstName;
            testCustomer.LastName = lastName;
            Assert.True(testCustomer.FirstName != "George");
        }


        [Fact]
        public void LocationModelFactTest()
        {
            LocationModel testLocation = new LocationModel();
            testLocation.Country = "China";
            testLocation.Address = "Spooner st";
            testLocation.AreaCode = 12352;
            Assert.False(testLocation.Address == "Random street");
        }

        [Theory]
        [InlineData("China", "Random street", -100)]
        public void LocationModelTheoryTest(string country, string address, int areaCode)
        {
            LocationModel testLocation = new LocationModel();
            testLocation.Country = country;
            testLocation.Address = address;
            testLocation.AreaCode = areaCode;
            Assert.False(testLocation.AreaCode > 0);
        }


        [Fact]
        public void ProductModelFactTest()
        {
            ProductModel testProduct = new ProductModel();
            testProduct.Name = "Swiffer";
            testProduct.Brand = "Swiffer brand";
            testProduct.Price = 19.99m;
            Assert.True(testProduct.Price > 0);
        }

        [Theory]
        [InlineData("Test product", "Test brand", 11.99)]
        public void ProductModelTheoryTest(string name, string brand, decimal price)
        {
            ProductModel testProduct = new ProductModel();
            testProduct.Name = name;
            testProduct.Brand = brand;
            testProduct.Price = price;
            Assert.True(testProduct.Name.Length > 0);
        }
    }
}
