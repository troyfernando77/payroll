using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Version2.Application;

namespace Version2.ViewComponents
{
  
    public class CompanyDropdownViewComponent : ViewComponent
    {
        private readonly ICompanyAppService _CompanyAppService;
        public CompanyDropdownViewComponent(ICompanyAppService CompanyAppService)
        {
            _CompanyAppService = CompanyAppService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string companyselected)
        {
            var companys = await this._CompanyAppService.GetAll();
            var company1 = companys.Select(m => new SelectListItem() {  Text = m.Name, Value = m.Name , Selected= m.Name== companyselected }) ;
            return await Task.FromResult((IViewComponentResult)View("CompanyDropdown", company1));
        }
    }
}
