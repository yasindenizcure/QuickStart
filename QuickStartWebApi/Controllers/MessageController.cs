using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public MessageController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult MessageList()
        {
            var value = _context.Messages.ToList();
            return Ok(value);
        }
        [HttpGet("MessageCount")]
        public IActionResult MessageCount()
        {
            var value = _context.Messages.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Message = _context.Messages.Find(id);
            return Ok(Message);
        }
        [HttpPost]
        public IActionResult CreateMessage(Message Message)
        {
            _context.Messages.Add(Message);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateMessage(Message Message)
        {
            _context.Messages.Update(Message);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
