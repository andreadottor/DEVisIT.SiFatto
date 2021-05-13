namespace DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories
{
    using DEVisIT.SiFatto.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IQuestionRepository : IRepository<Question, Guid>
    {
        Task<IEnumerable<Question>> GetQuestionsByUserAsync(string userId);
    }
}
