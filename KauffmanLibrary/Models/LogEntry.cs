using System;
using MongoDB.Bson.Serialization.Attributes;

namespace KauffmanLibrary.Models
{
    public class LogEntry
    {
        public string Name { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime Date { get; set; }
        public bool IsCheckingOut { get; set; }
    }
}
