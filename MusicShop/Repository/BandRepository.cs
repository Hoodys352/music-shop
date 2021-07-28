using MusicShop.Data;
using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Repository
{
    public class BandRepository : Repository<Band>, IBandRepository
    {
        public BandRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
