using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebComponent.Models;

namespace WebComponent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentFilesController : ControllerBase
    {
        private readonly DBContext _context;

        public ComponentFilesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/ComponentFiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ComponentFile>>> GetComponentFile()
        {
            return await _context.ComponentFile.ToListAsync();
        }

        // GET: api/ComponentFiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ComponentFile>> GetComponentFile(Guid id)
        {
            var componentFile = await _context.ComponentFile.FindAsync(id);

            if (componentFile == null)
            {
                return NotFound();
            }

            return componentFile;
        }

        // PUT: api/ComponentFiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComponentFile(Guid id, ComponentFile componentFile)
        {
            if (id != componentFile.FileId)
            {
                return BadRequest();
            }

            _context.Entry(componentFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComponentFileExists(id))
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

        // POST: api/ComponentFiles
        [HttpPost]
        public async Task<ActionResult<ComponentFile>> PostComponentFile(ComponentFile componentFile)
        {
            _context.ComponentFile.Add(componentFile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ComponentFileExists(componentFile.FileId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetComponentFile", new { id = componentFile.FileId }, componentFile);
        }

        // DELETE: api/ComponentFiles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ComponentFile>> DeleteComponentFile(Guid id)
        {
            var componentFile = await _context.ComponentFile.FindAsync(id);
            if (componentFile == null)
            {
                return NotFound();
            }

            _context.ComponentFile.Remove(componentFile);
            await _context.SaveChangesAsync();

            return componentFile;
        }

        private bool ComponentFileExists(Guid id)
        {
            return _context.ComponentFile.Any(e => e.FileId == id);
        }
    }
}
