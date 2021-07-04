using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Models.Entities
{
    public abstract class Product
    {
        public Guid Id { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "int")]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        public string FileName { get; set; }
    }
}
