using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public ServiceController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ServiceList() 
        {
            var value = _context.Services.ToList();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateService(Service service) 
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete]
        public IActionResult DeleteService(int id) 
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
