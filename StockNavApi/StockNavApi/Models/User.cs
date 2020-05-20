using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace StockNavApi.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }

        [Required]
        public string userName { get; set; }

        [EmailAddress]
        public string userEmail { get; set; }

        [PasswordPropertyText]
        public string userPassword { get; set; }

        [AllowNull]
        public string creditCard { get; set; }

        [Required]
        [StringLength(95)]
        public string address { get; set; }

        [Required]
        [StringLength(25)]
        public string fullName { get; set; }

        [AllowNull]
        public List<Portfolio> portfolios { get; set; }
    }
}
