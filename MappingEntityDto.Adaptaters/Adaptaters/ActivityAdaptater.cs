using MappingEntityDto.Common.Models;
using MappingEntityDto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEntityDto.Adaptaters.Adaptaters
{
    public static class ActivityAdaptater
    {
        public static ActivityResponse MapToActivityResponse(this Activity activity) { 
            return  new ActivityResponse() {
            Code = activity.Code,
            Name = activity.Name,
            ActivityType = activity.ActivityType.MapToActivityTypeResponse()    
            };
        }
    }
}
