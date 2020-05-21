using System;
using Xunit;
using Moq;
using StockNavApi.Models;
using StockNavApi.Controllers;
using Microsoft.EntityFrameworkCore;

namespace StockNavTesting
{
    public class UsersTest
    {
        User testUser = new User()
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
        [Fact]
        public void Test1()
        {
            //Testing User Getters and Setters
            testUser.userID = 1;
            testUser.userName = "example username";
            testUser.userEmail = "email@gmail.com";
            testUser.userPassword = "a";
            testUser.creditCard = null;
            testUser.address = "Address";
            testUser.fullName = "Example name";
            testUser.portfolios = null;
            Assert.NotNull(testUser);
        }
    }
}
