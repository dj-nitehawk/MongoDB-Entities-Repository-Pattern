using MongoDB.Entities;

namespace MongoTest.Entities
{
    public class Book : Entity
    {
        public string Title { get; set; }

        static Book()
        {
            DB.Index<Book>()
              .Key(b => b.Title, KeyType.Ascending)
              .CreateAsync();
        }
    }
}
