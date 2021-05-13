namespace DEVisIT.SiFatto.Domain.Entities
{
    using System;

    public class Question : Entity<Guid>
    {
        public string UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

    }
}
