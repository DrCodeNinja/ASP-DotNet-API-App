using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using TestApp.Services.Authors;
using TestApp.Services.Models;

namespace TestApp.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors()
        {
            var authors=_service.GetAllAuthors();
            var authorDto=_mapper.Map<ICollection<AuthorDto>>(authors);  
            return Ok(authorDto);
        }
        [HttpGet("{id}",Name = "GetAuthor")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }
            var authorDto=_mapper.Map<AuthorDto>(author);
            return Ok(authorDto); 
        }
        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(CreateAuthorDto author)
        {
            var autherEntity = _mapper.Map<Author>(author);
            var newAuthor=_service.AddAuthor(autherEntity);

            var authorForReturn=_mapper.Map<AuthorDto>(newAuthor);

            return CreatedAtRoute("GetAuthor", new {id=authorForReturn.Id},authorForReturn);
        }
    }
}
