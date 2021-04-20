namespace DEVisIT.SiFatto.Infrastructure
{
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories;
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Services;
    using DEVisIT.SiFatto.Infrastructure.Repositories;
    using DEVisIT.SiFatto.Infrastructure.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(
                                                this IServiceCollection services)
        {
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IMailService, MailService>();
            
            return services;
        }
    }
}
