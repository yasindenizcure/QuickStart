using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public GalleryController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GalleryList()
        {
            var value = _context.Galleries.ToList();
            return Ok(value);
        }
        [HttpGet("GalleryCount")]
        public IActionResult GalleryCount()
        {
            var value = _context.Galleries.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Gallery = _context.Galleries.Find(id);
            return Ok(Gallery);
        }
        [HttpPost]
        public IActionResult CreateGallery(Gallery Gallery)
        {
            _context.Galleries.Add(Gallery);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateGallery(Gallery Gallery)
        {
            _context.Galleries.Update(Gallery);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGallery(int id)
        {
            var value = _context.Galleries.Find(id);
            _context.Galleries.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
