using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebComponent.Models.Database;

namespace WebComponent.Models.Database.Repositories
{
    public class MemberRepository:IMemberRepository
    {
        private readonly ConnectionFactory _context;

        public MemberRepository()
        {
            _context = new ConnectionFactory();
        }
        public async Task<string> CheckAccount(Member _member)
        {
            Member theResult;
            ResultModel result = new ResultModel();
            result.IsSuccess = false;
            try
            {
                var cn = _context.CreateDBConnection();
                cn.Open();
                var sql = @"SELECT * FROM Member AS A WHERE A.Account=@Account";
                var res = await cn.QueryAsync<Member>(sql, _member);
                theResult = res.FirstOrDefault();

                if (theResult == null)
                {
                    result.Message = "Account is invalid!";
                    return result.ToJSON();
                }

                if (theResult.Password == _member.Password)
                {
                    result = new ResultModel();
                    result.IsSuccess = true;
                    result.Data = theResult;
                    result.Message = "Login Passed";

                    _member.LastLogIn = PublicMethod.getTime();

                    return result.ToJSON();
                }

                result.Message = "Password is wrong!";
                return result.ToJSON();
            }
            catch (Exception e)
            {
                result.Message = e.Message;
                result.IsSuccess = false;
                return result.ToJSON();
            }
        }
    }
}
