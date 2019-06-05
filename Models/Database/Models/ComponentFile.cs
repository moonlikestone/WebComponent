using System;
using System.Collections.Generic;

namespace WebComponent.Models
{
    public partial class ComponentFile
    {
        public ComponentFile()
        {
            DownloadRecord = new HashSet<DownloadRecord>();
        }

        public Guid FileId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string FileType { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastAccessTime { get; set; }

        public virtual ICollection<DownloadRecord> DownloadRecord { get; set; }
    }
}
