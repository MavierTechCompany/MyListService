using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyListService.Business_Logic.Models
{
    public class ThingOnList
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        protected ThingOnList()
        {

        }

        public ThingOnList(string name, string description)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;

            Name = name;
            Description = description;
        }
    }
}
