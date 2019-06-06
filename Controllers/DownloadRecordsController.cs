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
    public class DownloadRecordsController : ControllerBase
    {
        private readonly DBContext _context;

        public DownloadRecordsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/DownloadRecords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DownloadRecord>>> GetDownloadRecord()
        {
            return await _context.DownloadRecord.ToListAsync();
        }

        // GET: api/DownloadRecords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DownloadRecord>> GetDownloadRecord(long id)
        {
            var downloadRecord = await _context.DownloadRecord.FindAsync(id);

            if (downloadRecord == null)
            {
                return NotFound();
            }

            return downloadRecord;
        }

        // PUT: api/DownloadRecords/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDownloadRecord(long id, DownloadRecord downloadRecord)
        {
            if (id != downloadRecord.RecordId)
            {
                return BadRequest();
            }

            _context.Entry(downloadRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DownloadRecordExists(id))
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

        // POST: api/DownloadRecords
        [HttpPost]
        public async Task<ActionResult<DownloadRecord>> PostDownloadRecord(DownloadRecord downloadRecord)
        {
            _context.DownloadRecord.Add(downloadRecord);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DownloadRecordExists(downloadRecord.RecordId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDownloadRecord", new { id = downloadRecord.RecordId }, downloadRecord);
        }

        // DELETE: api/DownloadRecords/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DownloadRecord>> DeleteDownloadRecord(long id)
        {
            var downloadRecord = await _context.DownloadRecord.FindAsync(id);
            if (downloadRecord == null)
            {
                return NotFound();
            }

            _context.DownloadRecord.Remove(downloadRecord);
            await _context.SaveChangesAsync();

            return downloadRecord;
        }

        private bool DownloadRecordExists(long id)
        {
            return _context.DownloadRecord.Any(e => e.RecordId == id);
        }
    }
}
