using Microsoft.Extensions.DependencyInjection;
using student_management.IService;
using student_management.Service;

namespace student_management
{
    public class Startup1Base
    {
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddScoped<INotiService, NotiService>();
        }
    }
}