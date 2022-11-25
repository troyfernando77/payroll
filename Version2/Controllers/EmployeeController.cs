using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Application;
using Version2.Framework;
using Version2.Data.Models;

namespace Version2.Controllers
{
    public class EmployeeController : Controller 
    {
         
        private readonly IEmployeeAppService _EmployeeAppService;

        public EmployeeController(IEmployeeAppService EmployeeAppService)
        {
           
            this._EmployeeAppService = EmployeeAppService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this._EmployeeAppService.GetAll());
        }

        public IActionResult CreateorEdit(int id = 0)
        {

            var createorEditEmployeeDto = _EmployeeAppService.createorEditDto(new GetEmployee() { Id=id});
            return View(createorEditEmployeeDto);
        }
        public async Task<RedirectToActionResult> Delete(int id)
        {
            await _EmployeeAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<RedirectToActionResult> Save(CreateorEditEmployeeDto msg)
        {
            await _EmployeeAppService.CreateorEdit(msg);
            return RedirectToAction("Index");
        }
        public async Task<PartialViewResult> GetEmployees(int dtrheadid)
        {
            var employees = await this._EmployeeAppService.GetAll();
            return PartialView(employees);
        }
    }
}
