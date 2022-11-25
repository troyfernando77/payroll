using Microsoft.AspNetCore.Mvc;
using Payroll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValueObjects.ValueObject;
using Version2.Application;
using Version2.Framework;
using Version2.Data.Models;

namespace Version2.Controllers
{
    public class DTRController : Controller 
    {
         
        private readonly IDTRAppService _DTRAppService;

        public DTRController(IDTRAppService DTRAppService)
        {
           
            this._DTRAppService = DTRAppService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this._DTRAppService.GetAll());
        }
   
        public IActionResult CreateorEdit(CreateorEditDTRDto input)
        {       

            if (input.Id>0)
                input = _DTRAppService.createorEditDto(input.Id);
            return View(input);
        }
        public IActionResult SelectEmployee(EmployeeDto employee)
        {
            var dtr = new CreateorEditDTRDto();
            dtr.EmployeeId = employee.EmployeeId;
            return RedirectToAction("CreateorEdit", dtr );
        }

        public async Task<RedirectToActionResult> Delete(int id)
        {
            await _DTRAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<RedirectToActionResult> Save(CreateorEditDTRDto msg)
        {
            
            await _DTRAppService.CreateorEdit(msg);
            return RedirectToAction("Index");
        }
        
    }
}
