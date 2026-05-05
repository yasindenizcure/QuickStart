using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickStartWebApi.Context;
using QuickStartWebApi.Entity;

namespace QuickStartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly QuickStartContext _context;

        public TeamController(QuickStartContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult TeamList()
        {
            var value = _context.Teams.ToList();
            return Ok(value);
        }
        [HttpGet("TeamCount")]
        public IActionResult TeamCount()
        {
            var value = _context.Teams.Count();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Team = _context.Teams.Find(id);
            return Ok(Team);
        }
        [HttpPost]
        public IActionResult CreateTeam(Team Team)
        {
            _context.Teams.Add(Team);
            _context.SaveChanges();
            return Ok("Ekleme başarıyla gerçekleşti.");
        }
        [HttpPut]
        public IActionResult UpdateTeam(Team Team)
        {
            _context.Teams.Update(Team);
            _context.SaveChanges();
            return Ok("Güncelleme başarılı bir şekilde gerçekleşti.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTeam(int id)
        {
            var value = _context.Teams.Find(id);
            _context.Teams.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işleminiz başarıyla gerçekleşti.");
        }
    }
}
