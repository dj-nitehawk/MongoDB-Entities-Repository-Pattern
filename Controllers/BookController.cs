using Microsoft.AspNetCore.Mvc;
using MongoTest.Entities;
using MongoTest.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoTest.Controllers
{
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookRepository repo;

        public BookController(IBookRepository repository)
        {
            repo = repository;
        }

        [HttpGet("/api/books")]
        public Task<List<Book>> Index()
        {
            return repo.GetAll();
        }

        [HttpGet("/api/books/create")]
        public Task CreateBook()
        {
            return repo.SaveBook(new Book { Title = "this is a test" });
        }
    }
}
