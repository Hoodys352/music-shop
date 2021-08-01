using Microsoft.AspNetCore.Mvc.Rendering;
using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Models
{
    public class AlbumViewModel
    {
        public Album Album { get; set; }
        public IEnumerable<SelectListItem> BandList { get; set; }
    }
}
