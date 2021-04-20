namespace DEVisIT.SiFatto.ApplicationCore
{
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Services;
    using DEVisIT.SiFatto.ApplicationCore.Services;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {

        public static IServiceCollection AddApplicationCore(
                                                this IServiceCollection services)
        {
            services.AddScoped<IQuestionService, QuestionService>();

            return services;
        }
    }
}
