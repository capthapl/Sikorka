using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Drzewo
{
    public sealed class MongoController
    {
        private static MongoController instance = null;
        private static readonly object padlock = new object();
        MongoController()
        {
            if (client == null)
                client = new MongoClient(Configuration.MongoConnectionString);
        }
        public static MongoController Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MongoController();
                    }
                    return instance;
                }
            }
        }

        private static MongoClient client;

        public async Task InsertSingletonDocument(string databaseName, string collectionname, string documentname, string data)
        {
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<ModelSingleton>(collectionname);
            ModelSingleton m = new ModelSingleton();
            m.Data = data;
            m.Document = documentname;
            await collection.ReplaceOneAsync<ModelSingleton>(
                x => x.Document == documentname,
                m,
                new UpdateOptions { IsUpsert = true }
            );
        }
    }
}
