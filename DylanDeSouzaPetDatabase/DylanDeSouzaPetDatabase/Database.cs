using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Runtime.CompilerServices;

namespace DylanDeSouzaPetDatabase
{
    public class Database
    {
        const string LOCAL_HOST = "mongodb://localhost:";
        const string PORT_NUMBER = null;

        public static MongoClient Connect(string portNumber)
        {
            return new MongoClient(LOCAL_HOST + PORT_NUMBER);
        }

        public static IMongoDatabase Fetch(string databaseName, string portNumber)
        {
            return Connect(portNumber).GetDatabase(databaseName);
        }

        public static FilterDefinition<BsonDocument> CreateFilter(string column, string value)
        {
            return Builders<BsonDocument>.Filter.Eq(column, value);
        }
    }
}
