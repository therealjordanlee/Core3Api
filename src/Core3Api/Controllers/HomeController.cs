using Core3Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Core3Api.Controllers
{
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private IMessageService _messageService;

        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Get()
        {
            return Ok(_messageService.GetMessage());
        }
    }
}