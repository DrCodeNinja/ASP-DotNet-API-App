using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using TestApp.Service;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private TodoServices _service;

        public TodosController()
        {
            _service = new TodoServices();
        }

        [HttpGet("id")]
        public IActionResult GetTodos(int? id)
        {
            var allTodos = _service.AllTodos();
            if (id == null)
            {
                return Ok(allTodos);
            }
            allTodos=_service.AllTodos().Where(t=>t.Id==id).ToList();
            return Ok(allTodos);
        }

        
    }
}
