using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebComponent.Models
{
    public static class PublicMethod
    {
        public static string getTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
