namespace MappingEntityDto.Domain.Entities
{
    public class ActivityType
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Activity> Activities { get; set; }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}