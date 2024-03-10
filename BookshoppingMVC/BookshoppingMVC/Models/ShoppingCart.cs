using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookshoppingMVC.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        public int id { get; set; }
        [Required]
        public int userid { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
