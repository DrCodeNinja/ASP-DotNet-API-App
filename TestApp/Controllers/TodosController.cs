using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Services.Models;
using TestApp.Services.Todos;


namespace TestApp.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController] 
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _service;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository,IMapper mapper)
        {
            _service = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)
        {
            var allTodos = _service.AllTodos(authorId);
            var todoDto=_mapper.Map<ICollection<TodoDto>>(allTodos);
            return Ok(todoDto);
        }
        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todo= _service.GetTodo(authorId,id);
            if (todo == null)
            {
                return NotFound();
            }
            var todoDto=_mapper.Map<TodoDto>(todo);
            return Ok(todoDto);  
        }

         
    }
}
