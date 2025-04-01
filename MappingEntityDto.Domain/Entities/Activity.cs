using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEntityDto.Domain.Entities
{
    public class Activity
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public ActivityType ActivityType { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
