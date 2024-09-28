using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Service;
using TestApp.Services;


namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _service;

        public TodosController(ITodoRepository repository)
        {
            _service = repository;
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
