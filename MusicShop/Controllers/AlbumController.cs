using Microsoft.AspNetCore.Mvc;
using MusicShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public AlbumController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(Guid Id)
        {
            var albumDetails = await unitOfWork.Albums.Find(Id);
            var bandName = await unitOfWork.Bands.Find(albumDetails.BandId);
            albumDetails.Band.Name = bandName.Name;
            return View(albumDetails);
        }
    }
}
