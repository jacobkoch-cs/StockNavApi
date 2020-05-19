using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockNavApi.Models
{
    public class User
    {
        public int userID;

        public string userName;

        public string userEmail;

        public string userPassword;

        public string creditCard;

        public string address;

        public string fullName;

        public List<Portfolio> portfolios;
    }
}
