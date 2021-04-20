namespace DEVisIT.SiFatto.ApplicationCore
{
    using DEVisIT.SiFatto.ApplicationCore.Interfaces.Services;
    using DEVisIT.SiFatto.ApplicationCore.Services;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
