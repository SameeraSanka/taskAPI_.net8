using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taskAPI.Servises;
using TaskAPI.Servises;

namespace taskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {

        private readonly ITodoRepository _todoServise;

        public ToDosController(ITodoRepository repository)
        {
            _todoServise = repository;
        }

        [HttpGet ("{id?}")]
        public IActionResult GetToDos(int? id=0)  // me ? mark eken balanwa id eka null da enne naththan value ekak ewanwada kiyla.
        {
            var myTodos = _todoServise.allTodos(); // pahaala return eken ewna todos thiyna method eka variable ekakata assign krala retun krnawa
           
            if (id is null || id==0) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.Id == id).ToList();

            
            return Ok(myTodos);
        }
    }
}
