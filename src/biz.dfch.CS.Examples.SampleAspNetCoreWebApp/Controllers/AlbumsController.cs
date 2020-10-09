using biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models;
using Default;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApp.Controllers
{
    public class AlbumsController : Controller
    {
        private Container container;

        public AlbumsController()
        {
            container = new Container(new Uri("https://localhost:44316/odata/"));
        }

        public IActionResult Index()
        {
            var albums = container.Albums.AddQueryOption("$expand","Songs");

            var viewModel = new Models.AlbumViewModel();
            viewModel.Albums = albums.ToList();

            return View(viewModel);
        }

        public IActionResult Create()
        {
            var album = new Album
            {
                Name = "MyAlbum"
            };

            container.AddToAlbums(album);
            container.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
