using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public ProductController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _context.Products.ToList();
            return Ok(value);
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            var value = _context.Products.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Product = _context.Products.Find(id);
            return Ok(Product);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product Product)
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product Product)
        {
            _context.Products.Update(Product);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Products.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
