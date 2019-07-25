using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;

namespace Drzewo
{
    public class MongoController
    {
        private string connectionString = "mongodb://localhost:27017";
        private static MongoClient client;

        public MongoController()
        {
            if (client == null)
                client = new MongoClient(connectionString);
        }

        public void InsertSingletonDocument(string databaseName, string collectionname, string documentname, string data)
        {
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<ModelSingleton>(collectionname);
            ModelSingleton m = new ModelSingleton();
            m.Data = data;
            m.Document = documentname;
            collection.ReplaceOneAsync<ModelSingleton>(
                x => x.Document == documentname,
                m,
                new UpdateOptions { IsUpsert = true }
            );
        }
    }
}
