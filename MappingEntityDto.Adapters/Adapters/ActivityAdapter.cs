using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingEntityDto.Common.Models;
using MappingEntityDto.Domain.Entities;

namespace MappingEntityDto.Adapters
{
    public static class ActivityAdapter
    {
        public static ActivityResponse MapToActivityResponse(this Activity activity)
        {
            return new ActivityResponse()
            {
                Code = activity.Code,
                Name = activity.Name,
                ActivityType = activity.ActivityType.MapToActivityTypeResponse(),
            };
        }
    }
}
