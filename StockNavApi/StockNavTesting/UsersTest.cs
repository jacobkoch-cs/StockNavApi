using System;
using Xunit;
using StockNavApi.Models;

namespace StockNavTesting
{
    public class UsersTest
    {
        [Fact]
        public void Test1()
        {
            //Testing User Getters and Setters
            var testUser = new User()
            {
                userID = 1,
                userName = "example username",
                userEmail = "email@gmail.com",
                userPassword = "a",
                creditCard = null,
                address = "12345 Adress",
                fullName = "Example Name",
                portfolios = null
            };

        }
    }
}
