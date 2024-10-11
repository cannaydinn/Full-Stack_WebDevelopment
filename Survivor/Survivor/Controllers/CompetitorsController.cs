using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Context;
using Survivor.Entities;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorDbContext _context;
        public CompetitorsController(SurvivorDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var competitors = await _context.Competitors.Include(c => c.Category).ToListAsync();
            return Ok(competitors);
        }

        [HttpGet("{api}")]
        public async Task<IActionResult> GetCompetitor(int id) 
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor is null)
            {
                return NotFound();
            }
            
            return Ok(competitor);
        }

        [HttpGet("categories/{categoryId}")]
        public async Task<IActionResult> GetCompetitorsByCategory(int categoryId)
        {
            var competitors = await _context.Competitors.Where(c => c.CategoryId == categoryId).ToListAsync();

            return Ok(competitors);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompetitor([FromBody] CompetitorEntitiy competitor)
        {
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCompetitor), new { id = competitor.Id }, competitor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompetitor(int id, [FromBody] CompetitorEntitiy competitor)
        {
            if (id != competitor.Id)
            {
                return BadRequest();
            }
                
            _context.Entry(competitor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitor(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);

            if (competitor is null)
            {
                return NotFound();
            }
                
            _context.Competitors.Remove(competitor);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
