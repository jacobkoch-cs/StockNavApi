using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockNavApi.Models
{
    public class Portfolio
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string label { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal risk { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal reward { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal totalProfit { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal totalCost { get; set; }

        [Required]
        public List<Share> shares { get; set; }
    }
}
