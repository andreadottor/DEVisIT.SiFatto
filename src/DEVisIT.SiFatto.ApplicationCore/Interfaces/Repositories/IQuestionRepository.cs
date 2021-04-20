namespace DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories
{
    using DEVisIT.SiFatto.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IQuestionRepository : IRepository<Question, Guid>
    {
        IEnumerable<Question> GetQuestionsByUser(string userId);
    }
}
