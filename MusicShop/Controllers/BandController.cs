using Microsoft.AspNetCore.Mvc;
using MusicShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.Controllers
{
    public class BandController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public BandController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> IndexAsync(Guid Id)
        {
            var bandDetails = await unitOfWork.Bands.Find(Id);
            bandDetails.Albums = await unitOfWork.Albums.GetAll(t => t.BandId == Id);
            return View(bandDetails);
        }
    }
}
