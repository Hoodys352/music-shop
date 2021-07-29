using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicShop.Models.Entities
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        public string ImageName { get; set; }

        public Guid BandId { get; set; }
        public Band Band { get; set; }
    }
}