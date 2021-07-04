using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Models.Entities
{
    public class Band
    {
        public Guid Id { get; set; }
        
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}