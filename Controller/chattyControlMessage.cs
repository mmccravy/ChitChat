using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Chatty.Properties
{
    [Route("api/")]
    [ApiController]
    public class chattyControlMessage : ControllerBase
    {
        private readonly ChatService _chatService;
        public chattyControllMessage(ChatService chatService)
        {
            _chatService = chatService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] superData data)
        {
            var result = _chatService.OnChat(data.Data.From, data.Data.Body);
            Console.WriteLine(JsonSerializer.Serialize(data));
            return Ok(data);
        }
    }
}

