using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingEntityDto.Common.Models;
using MappingEntityDto.Domain.Entities;

namespace MappingEntityDto.Adapters
{
    public static class ActivityTypeAdapter
    {
        public static ActivityTypeResponse MapToActivityTypeResponse(this ActivityType activity)
        {
            return new ActivityTypeResponse() { Code = activity.Code, Name = activity.Name };
        }
    }
}
