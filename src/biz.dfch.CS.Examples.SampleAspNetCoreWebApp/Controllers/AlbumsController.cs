using biz.dfch.CS.Examples.SampleAspNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApp.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index()
        {
            var albums = new AlbumViewModel
            {
                Albums = new List<Album>
            {
                new Album { Name = "First Album" },
                new Album { Name = "Second Album" },
                new Album { Name = "Third Album" }
            }
            };

            return View(albums);
        }
    }
}
