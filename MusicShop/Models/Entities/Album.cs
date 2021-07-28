using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Models.Entities
{
    public class Album
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        public Guid BandId { get; set; }
        public Band Band { get; set; }
    }
}