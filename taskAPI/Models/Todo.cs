 namespace taskAPI.Models
{
    public class Todo
    {
         public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set;}
        public DateTime Due { get; set;}
        public TodoStates Status { get; set;}
    }
}
