using System.ComponentModel.DataAnnotations;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class Size
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string sizeNumber { get; set; }
    }
}
