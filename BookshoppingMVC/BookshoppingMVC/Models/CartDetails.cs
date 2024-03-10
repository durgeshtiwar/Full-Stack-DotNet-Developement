using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookshoppingMVC.Models
{
    [Table("Cart")]
    public class CartDetails
    {
        public int Id { get; set; }
        [Required]
        public int ShopingCartId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Book Book { get; set; }
        public ShoppingCart shoppingCart { get; set; }
    }
}
