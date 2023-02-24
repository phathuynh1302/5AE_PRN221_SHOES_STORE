using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    [Table("ShoesImage")]
    public class ShoesImage
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("ImageId")]
        public Image image { get; set; }

        [ForeignKey("ShoesId")]
        public Shoes shoes { get; set; }
    }
}
