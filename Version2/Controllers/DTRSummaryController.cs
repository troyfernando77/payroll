using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
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
    public class DTRSummaryController : Controller 
    {
         
        private readonly IDTRSummaryAppService _DTRSummaryAppService;
        private readonly IDTRAppService _dTRAppService;

        public DTRSummaryController(IDTRSummaryAppService DTRSummaryAppService, IDTRAppService dTRAppService)
        {
           
            this._DTRSummaryAppService = DTRSummaryAppService;
            this._dTRAppService = dTRAppService;
        }
        public async Task<IActionResult> Index(int DTRHeadId)
        {
            ViewBag.DTRHEadId = DTRHeadId;
            var dtrsummarys = await this._DTRSummaryAppService.GetAll();
            var dtrsummary = dtrsummarys.Where(m => m.DTRHeadId == DTRHeadId);
            var findseelcted = dtrsummary.Where(m => m.Id.ToString() == TempData["selected"].ToString());
            if (TempData["selected"] == null || findseelcted.Count() == 0)
                if (dtrsummary.Count() > 0)
                    TempData["selected"] = dtrsummary.First().Id;
                else
                    TempData["selected"] = -1;
            return View();
        }
   
        public IActionResult CreateorEdit(int id=0)
        {
             
            var  createorEditDTRSummaryDto = _DTRSummaryAppService.createorEditDto(id);
            createorEditDTRSummaryDto.DTRHeadId = 2;
            return View(createorEditDTRSummaryDto);
        }
        public async Task<IActionResult> DeleteDTR(int dtrid, int DTRSummaryId)
        {
            await _DTRSummaryAppService.DeleteDTR(dtrid);
            try
            {
                  await _DTRSummaryAppService.UpdateTotal(DTRSummaryId);
               
            }
            catch(Exception err)
            {

            }
            await _DTRSummaryAppService.Complete();
            return RedirectToAction("Select", new { dtrsummaryid= DTRSummaryId });
        }
        public async Task<RedirectToActionResult> SaveDTRs(List<DTRDto> dtrs , int DTRHeadId)
        {
            await _DTRSummaryAppService.SaveDTR(dtrs.ToArray(), DTRHeadId);
  

            return RedirectToAction("Index", new { DTRHeadId = DTRHeadId });
        }
        public async Task<RedirectToActionResult> Save(CreateorEditDTRSummaryDto msg)
        {
            
            await _DTRSummaryAppService.CreateorEdit(msg);
            return RedirectToAction("Index");
        }
        public async Task<PartialViewResult> ShowEmployees(int dtrheadid)  
        {
            var dtrsummarys = await this._DTRSummaryAppService.GetAll();
            var dtrsummary = dtrsummarys.Where(m => m.DTRHeadId == dtrheadid);
            var findseelcted = dtrsummary.Where(m => m.Id.ToString() == TempData["selected"].ToString());
            if (TempData["selected"] ==null || findseelcted.Count() == 0)
                if (dtrsummary.Count() > 0)
                    TempData["selected"] = dtrsummary.First().Id;
                else
                    TempData["selected"] = -1;
            ViewBag.DTRHeadId = dtrheadid;
            return PartialView(dtrsummary);
        }
        public PartialViewResult Select(int dtrsummaryid)
        {
            if (dtrsummaryid > 0)
                TempData["selected"] = dtrsummaryid.ToString();
            else
                dtrsummaryid = int.Parse( TempData["selected"].ToString());
            var dtrs = _DTRSummaryAppService.GetAllDTR(dtrsummaryid).Result;
            return PartialView(dtrs);
        }
        public IActionResult AddDtr(int DTRHeadId)
        {
            ViewBag.DTRHeadId = DTRHeadId;
            var dtrs = _DTRSummaryAppService.GetAllDTR(0).Result;
            return View(dtrs.ToArray());
        }
    }
}
