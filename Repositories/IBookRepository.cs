using MongoTest.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoTest.Repositories
{
    public interface IBookRepository
    {
        public Task SaveBook(Book bookToSave);
        public Task<Book> GetByTitle(string title);
        public Task<List<Book>> GetAll();
    }
}
