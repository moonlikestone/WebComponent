using System;
using System.Collections.Generic;

namespace WebComponent.Models
{
    public partial class Component
    {
        public Component()
        {
            Member = new HashSet<Member>();
        }

        public long Id { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Create { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
