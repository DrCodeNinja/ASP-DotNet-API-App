using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos(int authorId);
        public Todo GetTodo(int authorId, int id);
    }
}
