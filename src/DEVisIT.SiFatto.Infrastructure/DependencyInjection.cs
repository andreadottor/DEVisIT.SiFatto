namespace DEVisIT.SiFatto.Infrastructure
{
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Repositories;
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Services;
    using DEVisIT.SiFatto.Infrastructure.Repositories;
    using DEVisIT.SiFatto.Infrastructure.Services;
    using Microsoft.Extensions.DependencyInjection;

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
