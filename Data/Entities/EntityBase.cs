namespace ZestMonitor.Api.Data.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}