using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public SubscribeController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var value = _context.Subscribes.ToList();
            return Ok(value);
        }
        [HttpGet("SubscribeCount")]
        public IActionResult SubscribeCount()
        {
            var value = _context.Subscribes.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Subscribe = _context.Subscribes.Find(id);
            return Ok(Subscribe);
        }
        [HttpPost]
        public IActionResult CreateSubscribe(Subscribe Subscribe)
        {
            _context.Subscribes.Add(Subscribe);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateSubscribe(int id, Subscribe subscribe)
        {
            var value = _context.Subscribes.Find(id);

            if (value == null)
                return NotFound();

            value.Email = subscribe.Email;

            _context.SaveChanges();
            return Ok("Güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var value = _context.Subscribes.Find(id);
            _context.Subscribes.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
