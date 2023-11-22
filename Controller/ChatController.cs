using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;

namespace Chatty.Controllers
{
    [Route("api/")]
    [ApiController]
    public class chattyController : ControllerBase
    {
        private readonly ChatService _chatService;
      
        public chattyController(ChatService chatService)
        {
            _chatService = chatService;
        }
        [HttpGet("{number}/{id}")]
        public IActionResult OnChat(string number, string? id)
        {
            var result = _chatService.OnChat(number, id);
            return Ok(result);
        }


    }
}
