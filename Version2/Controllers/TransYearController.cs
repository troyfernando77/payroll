using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Version2.Application;
using Version2.Data.Models;

namespace Version2.Controllers
{
    public class TransYearController : Controller
    {
    
        private readonly ITransYearAppService _TransYearAppService;

        public TransYearController(ITransYearAppService TransYearAppService)
        {

            this._TransYearAppService = TransYearAppService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this._TransYearAppService.GetAll());
        }
        public IActionResult CreateorEdit(int id = 0)
        {

            var createorEditCompanyDto = _TransYearAppService.createorEditDto(new GetTransYear() { Id = id });
            return View(createorEditCompanyDto);
        }
        public async Task<RedirectToActionResult> Delete(int id)
        {
            await _TransYearAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Save(CreateorEditTransYearDto msg)
        {
            try
            {
                await _TransYearAppService.CreateorEdit(msg);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
            return RedirectToAction("Index");
        }
    }
}
