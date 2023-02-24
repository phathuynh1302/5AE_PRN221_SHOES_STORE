using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class ShoesColor
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("ShoesId")]
        public Shoes shoes { get; set; }

        [ForeignKey("ShoesId")]
        public Color color { get; set; }
    }
}
