using System;
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Models.Entities
{
    public class Album : Product
    {
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        public Guid BandId { get; set; }
        public Band Band { get; set;  }
    }
}
