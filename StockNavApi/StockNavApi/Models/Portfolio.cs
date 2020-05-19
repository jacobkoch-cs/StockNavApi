using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockNavApi.Models
{
    public class Portfolio
    {
        public string label;

        public double risk;

        public double reward;

        public double totalProfit;

        public double totalCost;

        public List<Share> shares;
    }
}
