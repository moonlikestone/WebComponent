using System;
using System.Collections.Generic;

namespace WebComponent.Models
{
    public partial class Component
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Create { get; set; }
        public string LastUpdate { get; set; }

    }
}
