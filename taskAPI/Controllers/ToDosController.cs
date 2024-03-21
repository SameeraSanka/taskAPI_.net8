using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace taskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetToDos() 
        { 
            return Ok();
        }
    }
}
