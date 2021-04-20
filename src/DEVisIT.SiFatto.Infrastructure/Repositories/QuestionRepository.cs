namespace DEVisIT.SiFatto.Infrastructure.Repositories
{
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories;
    using DEVisIT.SiFatto.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class QuestionRepository : IQuestionRepository
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetAll()
        {
            throw new NotImplementedException();
        }

        public Question GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetQuestionsByUser(string userId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Question entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Question entity)
        {
            throw new NotImplementedException();
        }
    }
}
