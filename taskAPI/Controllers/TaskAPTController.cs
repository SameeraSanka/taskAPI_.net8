using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace taskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //this a clz level attribute
    public class TaskAPTController : ControllerBase
    {
        [HttpGet]  //this is method level attribute
        public IActionResult Tasks() //here user IActionResult as norma interface for return somthing and
                                     //it reture the states code as well. dont use string, int etc.
        {
            var tasks = new string[] { "tasl1", "tack2", "task3" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            var somthingwentwrong = true;
            if (somthingwentwrong)
                return BadRequest();
            return Ok();
        }

        [HttpDelete] 
        public IActionResult DeleteTask()
        {
            var somthingwentwrong = true;
            if (somthingwentwrong)
                return BadRequest();
            return Ok();
        }
    }
}
// this is test comment
