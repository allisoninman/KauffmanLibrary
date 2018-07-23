using System;
using System.Collections.Generic;
using KauffmanLibrary.Models;
using MongoDB.Bson;
using MongoDB.Driver;


namespace KauffmanLibrary.Accessors
{
    public class BookAccessor : IBookAccessor
    {
        private readonly IMongoDatabase _db;

        public BookAccessor()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _db = client.GetDatabase("KauffmanLibrary");
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var result = _db.GetCollection<Book>("Books").Find(new BsonDocument()).ToList();
            return result;
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
