using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int id { get; set; }

        [Required]
        public long quantity { get; set; }

        [Required]
        public double price { get; set; }

        [Required]
        public bool status { get; set; }

        [ForeignKey("specificallyShoesId")]
        public SpecificallyShoes shoes { get; set; }

        [ForeignKey("OrderId")]
        public Order order { get; set; }

    }
}
