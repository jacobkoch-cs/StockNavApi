using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockNavApi.Models
{
    public class Share
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal purchasePrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal currentPrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal profit { get; set; }

        [Required]
        public int quantity { get; set; }

        [Required]
        public DateTime purchaseDate { get; set; }

        [Required]
        public bool sold { get; set; }
    }
}
