using System;
using System.Collections.Generic;

namespace WebComponent.Models
{
    public partial class DownloadRecord
    {
        public string Downloader { get; set; }
        public DateTime Time { get; set; }
        public Guid FileId { get; set; }
        public long RecordId { get; set; }

        public virtual Member DownloaderNavigation { get; set; }
        public virtual ComponentFile File { get; set; }
    }
}
