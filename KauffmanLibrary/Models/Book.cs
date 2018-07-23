using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KauffmanLibrary.Models
{
    public class Book
    {
        public ObjectId Id { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("Barcode")]
        public string Barcode { get; set; }

        [BsonElement("Genres")]
        public List<string> Genres { get; set; }

        [BsonElement("Ratings")]
        public List<Rating> Ratings { get; set; }

        [BsonElement("LogEntries")]
        public List<LogEntry> LogEntries { get; set; }
    }
}
