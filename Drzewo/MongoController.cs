using Drzewo.Model;
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

        public async Task InsertSingletonDocument(string databaseName, string collectionname, string documentname, EntityBase data)
        {
            try
            {
                var database = client.GetDatabase(databaseName);
                var collection = database.GetCollection<EntityBase>(collectionname);
                await collection.ReplaceOneAsync<EntityBase>(
                    x=>x.
                    data,
                    new UpdateOptions { IsUpsert = true }
                ); 
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }
        public async Task InsertSingletonDocument(string databaseName, string collectionname, string documentname, String data)
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
