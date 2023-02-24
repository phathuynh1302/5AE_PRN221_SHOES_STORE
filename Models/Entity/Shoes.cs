using System;
using System.ComponentModel.DataAnnotations;

namespace ShoesStoreProjectPrn.Models.Entity
{
    public class Shoes
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        [StringLength(200)]
        public string shoesDetails { get; set; }

        public DateTime? launchDate { get; set; }

        public long quantity { get; set; }
    }
}
