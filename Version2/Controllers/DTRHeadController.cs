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
using Version2.Application;

namespace Version2.Controllers
{
    public class DTRHeadController : Controller 
    {
         
        private readonly IDTRHeadAppService _DTRHeadAppService;

        public DTRHeadController(IDTRHeadAppService DTRHeadAppService)
        {
           
            this._DTRHeadAppService = DTRHeadAppService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this._DTRHeadAppService.GetAll());
        }
   
        public IActionResult CreateorEdit(int id=0)
        {
             
            var  createorEditDTRHeadDto = _DTRHeadAppService.createorEditDto(id);
            return View(createorEditDTRHeadDto);
        }
        public async Task<RedirectToActionResult> Delete(int id)
        {
            await _DTRHeadAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<RedirectToActionResult> Save(CreateorEditDTRHeadDTO msg)
        {
            
            await _DTRHeadAppService.CreateorEdit(msg);
            return RedirectToAction("Index");
        }
    }
}
