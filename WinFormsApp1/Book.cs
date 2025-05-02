﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WinFormsApp1
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        [BsonElement("Availability")]
        public string Availability { get; set; }
    }
}
