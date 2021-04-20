namespace DEVisIT.SiFatto.ApplicationCore.Services
{
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories;
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class QuestionService : IQuestionService
    {

        private readonly IQuestionRepository _questionRepository;
        private readonly IMailService _mailService;

        public QuestionService(
                    IQuestionRepository questionRepository, 
                    IMailService mailService)
        {
            _questionRepository = questionRepository;
            _mailService = mailService;
        }
    }
}
