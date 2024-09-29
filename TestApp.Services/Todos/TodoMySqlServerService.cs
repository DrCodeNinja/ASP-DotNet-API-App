using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess;
using TestApp.Models;

namespace TestApp.Services.Todos
{
    public class TodoMySqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllTodos(int authorId)
        {
            return _context.Todos.Where(t=>t.AuthorId==authorId).ToList(); 
        }
        public Todo GetTodo(int authorId, int id)
        {
            return _context.Todos.FirstOrDefault(t=>t.Id==id && t.AuthorId==authorId);
        }
    }

}
