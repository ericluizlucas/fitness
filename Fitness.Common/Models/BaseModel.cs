namespace Fitness.Common.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string? Uuid { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enable { get; set; }

        public BaseModel()
        {
            Uuid = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            Enable = true;
        }
    }
}