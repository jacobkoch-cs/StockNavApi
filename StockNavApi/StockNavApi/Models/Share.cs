using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockNavApi.Models
{
    public class Share
    {
        public double purchasePrice;

        public double currentPrice;

        public double profit;

        public int quantity;

        public DateTime purchaseDate;

        public bool sold;
    }
}
