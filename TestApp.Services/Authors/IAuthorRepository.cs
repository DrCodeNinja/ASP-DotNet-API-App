using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();
        public Author GetAuthor(int id);

        public Author AddAuthor(Author author); 
    }
}
