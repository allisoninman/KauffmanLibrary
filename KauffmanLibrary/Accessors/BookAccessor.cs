using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KauffmanLibrary.Models;
using MongoDB.Bson;
using MongoDB.Driver;


namespace KauffmanLibrary.Accessors
{
    public class BookAccessor
    {
        private MongoClient _client;
        private IMongoDatabase _db;

        public BookAccessor()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _db = _client.GetDatabase("KauffmanLibrary");
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _db.GetCollection<Book>("Books").Find(new BsonDocument()).ToList();
        }

        public bool IsBookCheckedOut(string barcode)
        {
            throw new NotImplementedException();
        }

        public void AddLogEntry(string barcode, string name, string isCheckingOut)
        {
            throw new NotImplementedException();
        }

    }
}
