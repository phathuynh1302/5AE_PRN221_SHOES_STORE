using System.ComponentModel.DataAnnotations;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class Sale
    {
        [Key]
        public int id { get; set; }

        [Required]
        public double discount { get; set; }
    }
}
