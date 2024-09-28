using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult TasksLists()
        {
            var tasks = new string[] { "Task 1"};
            return Ok(tasks);
        }
    }
}
