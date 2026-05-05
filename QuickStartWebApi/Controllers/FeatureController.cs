using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public FeatureController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _context.Features.ToList();
            return Ok(value);
        }
        [HttpGet("FeatureCount")]
        public IActionResult FeatureCount()
        {
            var value = _context.Features.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Feature = _context.Features.Find(id);
            return Ok(Feature);
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature Feature)
        {
            _context.Features.Add(Feature);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateFeature(Feature Feature)
        {
            _context.Features.Update(Feature);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _context.Features.Find(id);
            _context.Features.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
