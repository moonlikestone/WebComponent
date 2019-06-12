using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebComponent.Models;
using WebComponent.Models.Database.Repositories;

namespace WebComponent.Controllers
{
    [Route("api/Member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberRepository memberRepository;
        public MemberController(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        [HttpPost]
        [Route("CheckAccount")]
        public async Task<string> CheckAccount([FromBody]Member _member)
        {
            return await memberRepository.CheckAccount(_member);
        }

        //[HttpPost("[action]")]
        //public async Task<string> UpdateLogTime([FromBody]Member _member){
        //    ResultModel result = new ResultModel();
        //    Member updateMember = await _context.Member.FirstOrDefaultAsync(obj => obj.Account == _member.Account);
        //    updateMember.LastLogIn = DateTime.Now;

        //    try
        //    {
        //        _context.Member.Update(updateMember);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (Exception e)
        //    {
        //        result.Message = e.Message;
        //        result.IsSuccess = false;
        //        return result.ToJSON();
        //    }

        //    result.IsSuccess = true;
        //    return result.ToJSON();
        //}

    }
}