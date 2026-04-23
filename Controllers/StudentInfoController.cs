using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class StudentInfoController : ControllerBase
    {
        private readonly AppDBContext _context;
        public StudentInfoController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentInfo>>> Get(int? id)
        {
            if (id == null)
            {
                return await _context.StudentInfos.Take(5).ToListAsync();
            }
            var studentInfo = await _context.StudentInfos.FindAsync(id);
            if (studentInfo == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(new[] { studentInfo });
            }

        }


        [HttpPost]
        public async Task<ActionResult<StudentInfo>> Post(StudentInfo studentInfo)
        {
            _context.StudentInfos.Add(studentInfo);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = studentInfo.Id }, studentInfo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, StudentInfo studentInfo)
        {
            if (id != studentInfo.Id)
            {
                return BadRequest();
            }
            _context.Entry(studentInfo).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.StudentInfos.Any(e => e.Id == id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var studentInfo = await _context.StudentInfos.FindAsync(id);
            if (studentInfo == null)
            {
                return NotFound();
            }
            _context.StudentInfos.Remove(studentInfo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
