

using MappingEntityDto.Adaptaters.Adaptaters;
using MappingEntityDto.Domain.Entities;

var activity = new Activity() { 
Id = 1,
Name = "Test",
Code = "Test",
CreatedAt = DateTime.Now,
UpdatedAt = DateTime.Now,
};

var type = new ActivityType()
{
    Id = 2,
    Name = "Test",
    Code = "Test",
    CreatedAt = DateTime.Now,
    UpdatedAt = DateTime.Now,
    Activities = [activity]
};

activity.ActivityType = type;

var response = activity.MapToActivityResponse();

Console.WriteLine(response.ToString());