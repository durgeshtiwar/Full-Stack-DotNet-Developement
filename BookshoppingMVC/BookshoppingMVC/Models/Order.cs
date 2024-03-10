using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookshoppingMVC.Models
{
    [Table("Order")]
    public class Order
    {
        public int id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        [Required]
        public int OrderStatsId { get;set; }
        public bool isDeleted { get; set; }=false;
        public OrderStatus Orderstatus { get; set;}
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
