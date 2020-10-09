using biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Data;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Controllers
{
    public class AlbumsController : ODataController
    {
        private readonly MusicContext _context;
        public AlbumsController(MusicContext context)
        {
            _context = context;
            if (!context.Albums.Any())
            {
                _context.Database.EnsureCreated();
            }
        }

        [EnableQuery]
        public IActionResult Get()
        {
            var albums = _context.Albums;
            return Ok(albums);
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var album = _context.Albums.Include(a => a.Songs).Where(a => a.Id == key);
            if (album == null)
            {
                return NotFound();
            }
            return Ok(album);
        }
    }
}
