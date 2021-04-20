namespace DEVisIT.SiFatto.Domain.Entities
{
    public abstract class Entity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
