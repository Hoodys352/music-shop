using System;

namespace MusicShop.Models.Entities
{
    public class Album
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Guid BandId { get; set; }
        public Band Band { get; set; }
    }
}