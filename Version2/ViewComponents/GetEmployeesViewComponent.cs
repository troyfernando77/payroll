using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Version2.Application;

namespace Version2.ViewComponents
{
    public class GetEmployeesViewComponent : ViewComponent
    {
        private readonly IEmployeeAppService _EmployeeAppService;
        public GetEmployeesViewComponent(IEmployeeAppService employeeAppService)
        {
            _EmployeeAppService = employeeAppService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var employees = await this._EmployeeAppService.GetAll();
            return await Task.FromResult((IViewComponentResult)View("GetEmployees", employees.ToArray()));
        }
    }
}
