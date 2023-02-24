using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class SpecificallyShoesSale
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("specificallyShoes")]
        public SpecificallyShoes shoes { get; set; }

        [ForeignKey("saleId")]
        public Sale sale { get; set; }
    }
}
