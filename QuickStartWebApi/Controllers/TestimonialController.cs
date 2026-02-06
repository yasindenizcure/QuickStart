using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public TestimonialController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetTestimonials() 
        {
           var value = _context.Testimonials.ToList();
           return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Update(testimonial);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonials(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
