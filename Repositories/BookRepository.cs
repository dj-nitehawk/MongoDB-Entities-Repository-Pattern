using MongoDB.Entities;
using MongoTest.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoTest.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task SaveBook(Book bookToSave)
        {
            return bookToSave.SaveAsync();
        }

        public Task<List<Book>> GetAll()
        {
            return DB.Find<Book>()
                     .Match(_ => true)
                     .ExecuteAsync();
        }

        public Task<Book> GetByTitle(string title)
        {
            return DB.Find<Book>()
                     .Match(b => b.Title == title)
                     .ExecuteSingleAsync();
        }

    }
}
