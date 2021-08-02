using MusicShop.Data;
using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public class TracklistRepository : Repository<Tracklist>, ITracklistRepository
    {
        public TracklistRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
