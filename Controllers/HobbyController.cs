using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HobbyController : ControllerBase
    {
      private readonly AppDBContext _context;
        public HobbyController(AppDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hobby>>> Get(int? id)
        {
            if (id == null)
            {
                return await _context.Hobbies.Take(5).ToListAsync();
            }
            var hobby = await _context.Hobbies.FindAsync(id);
            if (hobby == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new[] { hobby });
            }
        }
        [HttpPost]
        public async Task<ActionResult<Hobby>> Post(Hobby hobby)
        {
            _context.Hobbies.Add(hobby);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = hobby.Id }, hobby);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Hobby hobby)
        {
            if (id != hobby.Id)
            {
                return BadRequest();
            }
            _context.Entry(hobby).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Hobbies.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
    }
}
