using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebComponent.Models.Database.Models
{
    public class FileResource
    {
        public string Id { get; set; }
        public byte[] File { get; set; }
        public string Type { get; set; }
        public string CreateTime { get; set; }
        public string RelId { get; set; }
    }
}
