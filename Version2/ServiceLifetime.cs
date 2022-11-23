using Microsoft.Extensions.DependencyInjection;
using Version2.Application;
using Version2.Framework;
using Version2.Data.Models;
using Version2.Application;

namespace Version2.Framework
{
    public static class ServiceLifetime
    {
        public static void Add(IServiceCollection services)
        {
            services.AddScoped<IRepository<Messages>, Repository<Messages>>();
            services.AddScoped<IRepository<Rule>, Repository<Rule>>();
            services.AddScoped<IRepository<Employee>, Repository<Employee>>();
            services.AddScoped<IRepository<DTR>, Repository<DTR>>();
            services.AddScoped<IRepository<DTRHead>, Repository<DTRHead>>();
            services.AddScoped<IRepository<DTRSummary>, Repository<DTRSummary>>();


            services.AddScoped<MessagesAppService>();
            services.AddScoped<RulesAppService>();
            services.AddScoped<IEmployeeAppService, EmployeeAppService>();
            services.AddScoped<IDTRAppService, DTRAppService>();
            services.AddScoped<IDTRHeadAppService, DTRHeadAppService>();
            services.AddScoped<IUnitofWork, UnitofWork>();
            
            services.AddScoped<IDTRSummaryAppService, DTRSummaryAppService>();

        }
        
    }
}
