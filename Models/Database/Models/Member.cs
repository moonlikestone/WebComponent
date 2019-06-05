using System;
using System.Collections.Generic;

namespace WebComponent.Models
{
    public partial class Member
    {
        public Member()
        {
            DownloadRecord = new HashSet<DownloadRecord>();
        }

        public string Account { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public DateTime? LastLogIn { get; set; }
        public long? RelComponent { get; set; }

        public virtual Component RelComponentNavigation { get; set; }
        public virtual ICollection<DownloadRecord> DownloadRecord { get; set; }
    }
}
