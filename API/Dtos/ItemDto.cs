using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ItemDto
    {
    [Required(ErrorMessage = "Item name is required.")]
    [StringLength(100, ErrorMessage = "Item name cannot be longer than 100 characters.")]
    public string ItemName { get; set; }
    
    public string Description { get; set; } // Optional field, can be omitted or null
    
    [Required(ErrorMessage = "Ingredient is required.")]
    public string Ingredient { get; set; }
    
    [Required(ErrorMessage = "Price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }
    
    [Required(ErrorMessage = "Category is required.")]
    public string Category { get; set; }
    }
}