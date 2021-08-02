using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Models.Entities
{
    public class Tracklist
    {
        public Guid Id { get; set; }
        public IEnumerable<Song> Songs { get; set; } = new List<Song>();
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
