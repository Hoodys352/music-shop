using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MusicShop.Models;
using MusicShop.Models.Entities;
using MusicShop.Repository;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Authorize]
        public async Task<IActionResult> Manage()
        {
            var albums = await unitOfWork.Albums.GetAll();
            return View(albums);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var bandList = await unitOfWork.Bands.GetAll();
            var albumViewModel = new AlbumViewModel
            {
                Album = new Album(),
                BandList = bandList.Select(i => new SelectListItem {
                    Text = i.Name,
                    Value = i.Id.ToString()
                })
            };
            return View(albumViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AlbumViewModel albumViewModel)
        {
            var albumToAdd = new Album
            {
                Id = Guid.NewGuid(),
                Name = albumViewModel.Album.Name,
                Price = albumViewModel.Album.Price,
                ReleaseDate = albumViewModel.Album.ReleaseDate,
                BandId = albumViewModel.Album.BandId
            };
            await unitOfWork.Albums.Add(albumToAdd);
            await unitOfWork.Complete();
            return RedirectToAction("Manage");
        }
    }
}
