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
    public class ComponentsController : ControllerBase
    {
        private readonly DBContext _context;

        public ComponentsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Components
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Component>>> GetComponent()
        {
            return await _context.Component.ToListAsync();
        }

        // GET: api/Components/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Component>> GetComponent(long id)
        {
            var component = await _context.Component.FindAsync(id);

            if (component == null)
            {
                return NotFound();
            }

            return component;
        }

        // PUT: api/Components/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComponent(long id, Component component)
        {
            if (id != component.Id)
            {
                return BadRequest();
            }

            _context.Entry(component).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComponentExists(id))
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

        // POST: api/Components
        [HttpPost]
        public async Task<ActionResult<Component>> PostComponent(Component component)
        {
            _context.Component.Add(component);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ComponentExists(component.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetComponent", new { id = component.Id }, component);
        }

        // DELETE: api/Components/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Component>> DeleteComponent(long id)
        {
            var component = await _context.Component.FindAsync(id);
            if (component == null)
            {
                return NotFound();
            }

            _context.Component.Remove(component);
            await _context.SaveChangesAsync();

            return component;
        }

        private bool ComponentExists(long id)
        {
            return _context.Component.Any(e => e.Id == id);
        }
    }
}
