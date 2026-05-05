using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public SliderController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult SliderList()
        {
            var value = _context.Sliders.ToList();
            return Ok(value);
        }
        [HttpGet("SliderCount")]
        public IActionResult SliderCount()
        {
            var value = _context.Sliders.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Slider = _context.Sliders.Find(id);
            return Ok(Slider);
        }
        [HttpPost]
        public IActionResult CreateSlider(Slider Slider)
        {
            _context.Sliders.Add(Slider);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateSlider(Slider Slider)
        {
            _context.Sliders.Update(Slider);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSlider(int id)
        {
            var value = _context.Sliders.Find(id);
            _context.Sliders.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
