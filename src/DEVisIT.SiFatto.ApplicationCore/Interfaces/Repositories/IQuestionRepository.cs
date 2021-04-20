namespace DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories
{
    using DEVisIT.SiFatto.Domain.Entities;
    using System;
    using System.Collections.Generic;

    public interface IQuestionRepository : IRepository<Question, Guid>
    {
        IEnumerable<Question> GetQuestionsByUser(string userId);
    }
}
