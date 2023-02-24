using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class SpecificallyShoesSize
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("specificallyShoesId")]
        public SpecificallyShoesSize shoes { get; set;}

        [ForeignKey("sizeId")]
        public Size size { get; set; }
    }
}
