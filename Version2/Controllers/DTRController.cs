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
   
        public IActionResult CreateorEdit(int id=0)
        {
             
            var  createorEditDTRDto = _DTRAppService.createorEditDto(id);
            return View(createorEditDTRDto);
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
