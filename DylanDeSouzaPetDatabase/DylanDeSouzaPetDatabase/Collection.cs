using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DylanDeSouzaPetDatabase
{
    public class Collection
    {
        public static IMongoCollection<BsonDocument> Fetch(IMongoDatabase database, string name)
        {
            return database.GetCollection<BsonDocument>(name);
        }

        public static void AddTo(BsonDocument document, IMongoCollection<BsonDocument> collection)
        {
            collection.InsertOne(document);
        }
    }
}
