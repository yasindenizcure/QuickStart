using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public AboutController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _context.Abouts.ToList();
            return Ok(value);
        }
        [HttpGet("AboutCount")]
        public IActionResult AboutCount()
        {
            var value = _context.Abouts.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var About = _context.Abouts.Find(id);
            return Ok(About);
        }
        [HttpPost]
        public IActionResult CreateAbout(About About)
        {
            _context.Abouts.Add(About);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateAbout(About About)
        {
            _context.Abouts.Update(About);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
