using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Apicompassdois.Context;
using Apicompassdois.Model;

namespace Apicompassdois.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompassesController : ControllerBase
    {
        private readonly DataContext _context;

        public CompassesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Compasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compass>>> GetCompasses()
        {
          if (_context.Compasses == null)
          {
              return NotFound();
          }
            return await _context.Compasses.ToListAsync();
        }

        // GET: api/Compasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compass>> GetCompass(int id)
        {
          if (_context.Compasses == null)
          {
              return NotFound();
          }
            var compass = await _context.Compasses.FindAsync(id);

            if (compass == null)
            {
                return NotFound();
            }

            return compass;
        }

        // PUT: api/Compasses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompass(int id, Compass compass)
        {
            if (id != compass.Id)
            {
                return BadRequest();
            }

            _context.Entry(compass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompassExists(id))
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

        // POST: api/Compasses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Compass>> PostCompass(Compass compass)
        {
          if (_context.Compasses == null)
          {
              return Problem("Entity set 'DataContext.Compasses'  is null.");
          }
            _context.Compasses.Add(compass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompass", new { id = compass.Id }, compass);
        }

        // DELETE: api/Compasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompass(int id)
        {
            if (_context.Compasses == null)
            {
                return NotFound();
            }
            var compass = await _context.Compasses.FindAsync(id);
            if (compass == null)
            {
                return NotFound();
            }

            _context.Compasses.Remove(compass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompassExists(int id)
        {
            return (_context.Compasses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
