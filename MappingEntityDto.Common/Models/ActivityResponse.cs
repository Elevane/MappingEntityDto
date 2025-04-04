﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEntityDto.Common.Models
{
    public class ActivityResponse
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ActivityTypeResponse ActivityType { get; set; }

        public string ToString()
        {
            return $"Name : {Name}-Code: {Code}-Type : [{ActivityType.ToString()}]";
        }
    }
}
