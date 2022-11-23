using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Version2.Application;
using Version2.Data.Models;

namespace Version2.Controllers
{
    public class RulesController : Controller 
    {
         
        private readonly RulesAppService _rulesAppService;
        private readonly IMapper _mapper;
        List<SelectListItem> selectStatusItems=new List<SelectListItem>();
        List<SelectListItem> selectMainItems = new List<SelectListItem>();

        public RulesController(RulesAppService rulesAppService, IMapper mapper)
        {
            SelectListItem[] selectItem = {new SelectListItem("Active","Active    "),
                                            new SelectListItem("Powered", "Powered   ") };
            selectStatusItems.AddRange(selectItem);
            this._rulesAppService = rulesAppService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.category = "Main";
            return View(await this._rulesAppService.GetAll("Main"));
        }
        public async Task<IActionResult> SubRules()
        {
            await getMainRulenames();
            ViewBag.category = "Sub";
            return View("Index",await this._rulesAppService.GetAll("Sub"));
        }
        async Task<int> getItemNo(string category)
        {
            var selectItem = await _rulesAppService.GetAll(category);
            return selectItem.Count();


        }
        async Task getMainRulenames()
        {
            var selectItem = (from a in await _rulesAppService.GetAll("Main")
                              select new SelectListItem()
                              {
                                  Text = a.RuleName,
                                  Value = a.RuleName
                              }).ToArray();
            this.selectMainItems.AddRange(selectItem);
            ViewBag.RuleNames = selectMainItems;
            
        }
        public async Task<IActionResult> CreateorEdit(int id=0, string category="Main")
        {

            int itemno =await getItemNo(category)+ 1;
            var createorEditMessagesDto =_rulesAppService.createorEditRulesDto(id, category, 
                itemno);
            ViewBag.statuslist = selectStatusItems;
            await getMainRulenames();
            ViewBag.category = category;
            return View(createorEditMessagesDto);
        }
        public RedirectToActionResult RedirectToActionResult(string category)
        {
            if (category == "Main")
                return RedirectToAction("Index");
            else
                return RedirectToAction("SubRules");
        }
        public async Task<RedirectToActionResult> Delete(int id, string category)
        {
                await _rulesAppService.Delete(id);
            return RedirectToActionResult(category);
        }
        public async Task<RedirectToActionResult> Save(CreateorEditRulesDto msg)
        {
            await _rulesAppService.CreateorEdit(msg);
            return RedirectToActionResult(msg.Category);
        }
    }
}
