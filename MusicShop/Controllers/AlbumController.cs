using Microsoft.AspNetCore.Mvc;
using MusicShop.Interfaces;
using MusicShop.Models;
using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;
        private readonly IBandService _bandService;
        public AlbumController(IAlbumService albumService
            ,IBandService bandService
            )
        {
            _albumService = albumService;
            _bandService = bandService;
        }

        public async Task<IActionResult> Index()
        {
            var albums = await _albumService.FindAllAsync();
            return View(albums);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Album album, string bandName)
        {
            var result = await _bandService.FindByNameAsync(bandName);
            if(result != null)
            {
                album.BandId = result.Id;
                await _albumService.CreateAsync(album);
            }
            return RedirectToAction("Index");
        }
    }
}
