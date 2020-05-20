using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockNavApi.Models
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}
