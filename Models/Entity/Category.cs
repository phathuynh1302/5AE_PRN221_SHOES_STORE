using System.ComponentModel.DataAnnotations;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
    }
}
