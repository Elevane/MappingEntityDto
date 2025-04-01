namespace MappingEntityDto.Common.Models
{
    public class ActivityTypeResponse
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public string ToString(){
            return $"{Name} - {Code}";
        }
    }
}