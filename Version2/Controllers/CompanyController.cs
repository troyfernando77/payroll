using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Version2.Application;
using Version2.Data.Models;

namespace Version2.Controllers
{
    public class CompanyController : Controller
    {
    
        private readonly ICompanyAppService _CompanyAppService;

        public CompanyController(ICompanyAppService ICompanyAppService)
        {

            this._CompanyAppService = ICompanyAppService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this._CompanyAppService.GetAll());
        }
        public IActionResult CreateorEdit(int id = 0)
        {

            var createorEditCompanyDto = _CompanyAppService.createorEditDto(new GetCompany() { Id = id });
            return View(createorEditCompanyDto);
        }
        public async Task<RedirectToActionResult> Delete(int id)
        {
            await _CompanyAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Save(CreateorEditCompanyDto msg)
        {
            try
            {
                await _CompanyAppService.CreateorEdit(msg);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
