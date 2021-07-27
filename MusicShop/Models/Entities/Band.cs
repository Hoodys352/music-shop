using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Models.Entities
{
    public class Band
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public DateTime FormationYear { get; set; }
        public DateTime? DisbandmentYear { get; set; }
        public IEnumerable<Album> Albums { get; set; } = new List<Album>();
    }
}
