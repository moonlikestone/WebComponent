using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebComponent.Models;
using System.Web.Http;
using WebComponent.Models.ReturnFile;

namespace WebComponent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : Controller
    {
        private readonly DBContext _context;

        public MembersController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Members
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Member>>> GetMember()
        {
            return await _context.Member.ToListAsync();
        }

        // GET: api/Members/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMember(string id)
        {
            var member = await _context.Member.FindAsync(id);
            
            if (member == null)
            {
                return NotFound();
            }

            return member;
        }

        // PUT: api/Members/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMember(string id, Member member)
        {
            if (id != member.Account)
            {
                return BadRequest();
            }

            _context.Entry(member).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberExists(id))
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

        // POST: api/Members
        [HttpPost]
        public async Task<ActionResult<Member>> PostMember(Member member)
        {
            _context.Member.Add(member);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MemberExists(member.Account))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMember", new { id = member.Account }, member);
        }

        // DELETE: api/Members/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Member>> DeleteMember(string id)
        {
            var member = await _context.Member.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }

            _context.Member.Remove(member);
            await _context.SaveChangesAsync();

            return member;
        }

        private bool MemberExists(string id)
        {
            return _context.Member.Any(e => e.Account == id);
        }
        [HttpPost("[action]")]
        public async Task<string> CheckAccount([FromBody]Member _member)
        {
            Member theResult;
            ResultModel result = new ResultModel();
            result.IsSuccess = false;
            theResult = await _context.Member.FirstOrDefaultAsync(obj => obj.Account == _member.Account);

            if(theResult == null){
                result.Message = "Account is invalid!";
                return result.ToJSON();
            }

            if(theResult.Password == _member.Password)
            {
                result = new ResultModel();
                result.IsSuccess = true;
                result.Data = theResult;
                result.Message = "Login Passed";

                _member.LastLogIn = DateTime.Now;

                return result.ToJSON();
            }

            result.Message = "Password is wrong!";
            return result.ToJSON();
        }

        
    }
}
