using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    [Table("Shoes")]
    public class SpecificallyShoes
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Column(TypeName = "Money")]
        public decimal price { get; set; }

        public long quantity { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? updateDate { get; set; }

        [ForeignKey("ShoesId")]
        public Shoes shoes { get; set; }
    }
}
