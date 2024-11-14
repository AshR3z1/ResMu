using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string ItemName { get; set; }
        public string Description { get; set; }
        [Required]
        public string Ingredient { get; set; }
        [Required]
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }
        [Required]
        public string Category { get; set; }
    }
}