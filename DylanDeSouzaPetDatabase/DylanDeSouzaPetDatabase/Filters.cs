using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DylanDeSouzaPetDatabase
{
    public static class Filters
    {
        public static FilterDefinition<BsonDocument> FindFirstOrDefaultBsonDocument(string column, string value)
        {
            return Builders<BsonDocument>.Filter.Eq(column, value);
        }

        public static BsonDocument FetchFirstBsonDocument(string column, string value, IMongoCollection<BsonDocument> collection)
        {
            return collection.Find(FindFirstOrDefaultBsonDocument(column, value)).FirstOrDefault();
        }

        public static void FetchDetails(BsonDocument document, string fetching)
        {
            Dictionary<string, object> dict = document.ToDictionary();
            Debug.WriteLine(dict[fetching]);
        }
    }
}
