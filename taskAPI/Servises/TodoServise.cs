using taskAPI.Models;

namespace taskAPI.Servises
{
    public class TodoServise
    {
        //Get todos
        //to get all we can use ICollection, IEnumarable or List.
        //if we use List then we have to write the odel name thith in <> this.
        public List<Todo> allTodos()
        {
            var todos = new List<Todo>();

            var todos1 = new Todo
            {
                Id = 1,
                Title = "Get book for Scl",
                Description = "Get some book for scl",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStates.New
            };
            todos.Add(todos1);

            var todos2 = new Todo
            {
                Id = 2,
                Title = "Get vege for Scl",
                Description = "Get some book for scl",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStates.Inprogress
            };
            todos.Add(todos2);

            var todos3 = new Todo
            {
                Id = 3,
                Title = "Get meet for Scl",
                Description = "Get some book for scl",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStates.Completed
            };
            todos.Add(todos3);
            return todos;
        }
    }
}
