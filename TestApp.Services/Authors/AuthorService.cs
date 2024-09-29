using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.DataAccess;
using TestApp.Models;

namespace TestApp.Services.Authors
{
    public class AuthorService : IAuthorRepository
    {
        private readonly TodoDbContext _context=new TodoDbContext();
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }

        public Author AddAuthor(Author author)
        {
              _context.Authors.Add(author);
            _context.SaveChanges();

            return _context.Authors.Find(author.Id);
        }
    }
}
