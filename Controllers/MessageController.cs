using Microsoft.AspNetCore.Mvc;

namespace TOPApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private static List<string> _messages =new();

        [HttpGet]
        public IActionResult GetLast()
        {

            return Ok(_messages);
        }

        [HttpPost]
        public IActionResult AddMessage([FromBody] string obj)
        {
            _messages.Add(obj);
            return Ok();
        }
    }
}