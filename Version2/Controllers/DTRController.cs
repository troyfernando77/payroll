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
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.Filters;

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
            if (input.Id > 0)
                input = _DTRAppService.createorEditDto(input.Id);
            else
            {
                input.TimeIn = DateTime.Now;
                input.TimeOut= DateTime.Now;
            }
            return View(input);
        }
       

        public async Task<RedirectToActionResult> Delete(int id)
        {
            await _DTRAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Save(CreateorEditDTRDto msg)
        {
            msg.TimeIn = ClassDate.GetDate(msg.TimeIn, msg.TimeInTime);
            msg.TimeOut = ClassDate.GetDate(msg.TimeOut, msg.TimeOutTime);
            var dto = await _DTRAppService.CreateorEdit(msg);
            if (dto.isFailed)
            {
                var req= BadRequest(dto.Message);
                return req;
            }
            return RedirectToAction("Index");
        }
        
        
    }
}
