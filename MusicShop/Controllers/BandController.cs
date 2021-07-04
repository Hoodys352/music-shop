using Microsoft.AspNetCore.Mvc;
using MusicShop.Data;
using MusicShop.Interfaces;
using MusicShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Controllers
{
    public class BandController : Controller
    {
        public readonly IBandService _bandService;

        public BandController(IBandService bandService)
        {
            _bandService = bandService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Band Band)
        {
            await _bandService.CreateAsync(Band);
            return RedirectToAction("Index");
        }
    }
}
