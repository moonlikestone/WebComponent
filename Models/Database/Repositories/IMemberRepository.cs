using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebComponent.Models.Database.Repositories
{
    public interface IMemberRepository
    {
        Task<string> CheckAccount(Member _member);
    }
}
