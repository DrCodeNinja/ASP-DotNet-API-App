using TestApp.Models;
using TestApp.Services;

namespace TestApp.Service
{
    public class TodoServices:ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Title A",
                Description = "Dis A",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Title B",
                Description = "Dis B",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Title C",
                Description = "Dis C",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);
            todos.Add(todo2);
            todos.Add(todo3);
            return todos;
        }
    }
}
