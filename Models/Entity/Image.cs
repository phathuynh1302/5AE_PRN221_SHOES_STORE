
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesStoreProjectPrn.Models.Entity
{
    [Table("Image")]
    public class Image
    {
        [Key]
        public int id { get; set; }

        public byte[] image { get; set; }

        public string createBy { get; set; }

        public DateTime? createDate { get; set; }

        public string updateBy { get; set; }

        public DateTime? lastModifiedDate { get; set;}

    }
}
