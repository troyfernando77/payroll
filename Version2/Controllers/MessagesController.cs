using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Version2.Application;
using Version2.Data.Models;

namespace Version2.Controllers
{
    public class MessagesController : Controller 
    {
         
        private readonly MessagesAppService _messagesAppService;

        public MessagesController(MessagesAppService messagesAppService)
        {
           
            this._messagesAppService = messagesAppService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this._messagesAppService.GetAll());
        }
   
        public IActionResult CreateorEdit(int id=0)
        {
            CreateorEditMessagesDto createorEditMessagesDto = new CreateorEditMessagesDto();
            if (id>0)
            {
                var msg = _messagesAppService.Get(id);
                createorEditMessagesDto.Id = msg.Id;
                createorEditMessagesDto.Message = msg.Message;
                createorEditMessagesDto.MessageCode = msg.MessageCode;
            }
            return View(createorEditMessagesDto);
        }
        public async Task<RedirectToActionResult> Delete(int id)
        {
            await _messagesAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public async Task<RedirectToActionResult> Save(CreateorEditMessagesDto msg)
        {
            await _messagesAppService.CreateorEdit(msg);
            return RedirectToAction("Index");
        }
    }
}
