namespace Fitness.Infrastructure.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enable { get; set; }

        public BaseEntity()
        {
            Uuid = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            Enable = true;
        }
    }
}