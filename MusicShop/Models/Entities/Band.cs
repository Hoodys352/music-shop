using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Models.Entities
{
    public class Band
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }

        [Column(TypeName = "Date")]
        public DateTime FormationYear { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? DisbandmentYear { get; set; }
        public IEnumerable<Album> Albums { get; set; } = new List<Album>();
    }
}
