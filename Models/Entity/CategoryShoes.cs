using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class CategoryShoes
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("categoryId")]
        public Category category { get; set; }

        [ForeignKey("shoesId")]
        public Shoes shoes { get; set; }
    }
}
