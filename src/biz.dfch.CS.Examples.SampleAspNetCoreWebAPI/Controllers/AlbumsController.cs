using biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Data;
using biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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
        public IActionResult GetAlbums()
        {
            var albums = _context.Albums;
            return Ok(albums);
        }

        [EnableQuery]
        public IActionResult GetAlbum(int key)
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

        [HttpPost]
        public Microsoft.AspNet.OData.Results.CreatedODataResult<Album> PostAlbum([FromBody] Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();

            return Created(album);
        }

        [HttpDelete]
        public IActionResult DeleteAlbum([FromODataUri] int key)
        {
            var album = _context.Albums.Find(key);

            if (album == null)
            {
                return NotFound();
            }

            _context.Remove(album);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateAlbum([FromODataUri] int key,[FromBody] Album album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != album.Id)
            {
                return BadRequest();
            }
            _context.Update(album);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(album);
        }

        private bool AlbumExists(int key)
        {
            return _context.Albums.Any(a => a.Id == key);
        }
    }
}
