using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using FSharpFUTService.Models;

namespace FSharpFUTTest
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConnectToMongo()
        {
            var client = new MongoClient(System.Configuration.ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            var database = client.GetDatabase("local");
            var collection = database.GetCollection<BsonDocument>("players");
            long count = collection.Count(new BsonDocument());
            Assert.AreNotEqual(0, count);
        }
        [TestMethod]
        public void ListNotEmptyWhenGettingSkillers()
        {
            var client = new MongoClient(System.Configuration.ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            var database = client.GetDatabase("local");
            var collection = database.GetCollection<BsonDocument>("players");
            var filter = Builders<BsonDocument>.Filter.Gt("skillMoves", 4);
            var projection = Builders<BsonDocument>.Projection.Exclude("_id");
            var results = collection.Find(filter).Project(projection);
            int count = (int)results.Count();
            Assert.AreNotEqual(0, count);

        }
        [TestMethod]
        public void CanIterateOverCollection()
        {
            //BsonClassMap.RegisterClassMap<Player>();
            var client = new MongoClient(System.Configuration.ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            var database = client.GetDatabase("local");
            var collection = database.GetCollection<BsonDocument>("players");
            var filter = Builders<BsonDocument>.Filter.Gt("skillMoves", 4);
            var projection = Builders<BsonDocument>.Projection.Exclude("_id").Exclude("id");
            var results = collection.Find(filter).Project(projection);
            foreach (var record in results.ToEnumerable())
            {
                var deserialized = BsonSerializer.Deserialize<Player>(record);
                Assert.IsNotNull(deserialized);
            }

        }
    }
}
