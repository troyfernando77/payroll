using Microsoft.Extensions.DependencyInjection;
using Version2.Data.Models;
 

namespace Version2
{
    public static class AutoMapper
    {
        public static void Add(IServiceCollection services)
        {
            services.AddAutoMapper(
              cfg =>
              {
                  cfg.CreateMap<Messages, MessagesDto>().ReverseMap();
                  cfg.CreateMap<Messages, CreateorEditMessagesDto>().ReverseMap();
                  cfg.CreateMap<Rule, RulesDto>().ReverseMap();
                  cfg.CreateMap<Rule, CreateorEditRulesDto>().ReverseMap();
                  cfg.CreateMap<RulesDto, CreateorEditRulesDto>().ReverseMap();
                  cfg.CreateMap<Employee, EmployeeDto>().ReverseMap();
                  cfg.CreateMap<Employee, CreateorEditEmployeeDto>().ReverseMap();
                  cfg.CreateMap<EmployeeDto, CreateorEditEmployeeDto>().ReverseMap();
                  cfg.CreateMap<DTR, DTRDto>().ReverseMap();
                  cfg.CreateMap<DTR, CreateorEditDTRDto>().ReverseMap();
                  cfg.CreateMap<DTRDto, CreateorEditDTRDto>().ReverseMap();
                  cfg.CreateMap<DTRHead, DTRHeadDTO>().ReverseMap();
                  cfg.CreateMap<DTRHead, CreateorEditDTRHeadDTO>().ReverseMap();
                  cfg.CreateMap<DTRHeadDTO, CreateorEditDTRHeadDTO>().ReverseMap();

                  cfg.CreateMap<DTRSummary, DTRSummaryDto>().ReverseMap();
                  cfg.CreateMap<DTRSummary, CreateorEditDTRSummaryDto>().ReverseMap();
                  cfg.CreateMap<DTRSummaryDto, CreateorEditDTRSummaryDto>().ReverseMap();

                  cfg.CreateMap<Company, CompanyDto>().ReverseMap();
                  cfg.CreateMap<Company, CreateorEditCompanyDto>().ReverseMap();
                  cfg.CreateMap<CompanyDto, CreateorEditCompanyDto>().ReverseMap();

                  cfg.CreateMap<TransYear, TransYearDto>().ReverseMap();
                  cfg.CreateMap<TransYear, CreateorEditTransYearDto>().ReverseMap();
                  cfg.CreateMap<TransYearDto, CreateorEditTransYearDto>().ReverseMap();

              });
        }
    }
}
