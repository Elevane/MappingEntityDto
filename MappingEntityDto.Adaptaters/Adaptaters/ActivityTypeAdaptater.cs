using MappingEntityDto.Common.Models;
using MappingEntityDto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEntityDto.Adaptaters.Adaptaters
{
    public static class ActivityTypeAdaptater
    {
        public static ActivityTypeResponse MapToActivityTypeResponse(this ActivityType activity)
        {
            return new ActivityTypeResponse()
            {
                Code = activity.Code,
                Name = activity.Name,
            };
        }
    }
}
