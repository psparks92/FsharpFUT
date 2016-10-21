using System;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            Assert.True(true);
        }

        // [Fact]
        // public void ConnectToMongo()
        // {
        //     var client = new MongoClient(System.Configuration.ConfigurationManager.ConnectionStrings["local"].ConnectionString);
        //     var database = client.GetDatabase("local");
        //     var collection = database.GetCollection<BsonDocument>("players");
        //     long count = collection.Count(new BsonDocument());
        //     Assert.AreNotEqual(0, count);
        // }
        // [Fact]
        // public void ListNotEmptyWhenGettingSkillers()
        // {
        //     var client = new MongoClient(System.Configuration.ConfigurationManager.ConnectionStrings["local"].ConnectionString);
        //     var database = client.GetDatabase("local");
        //     var collection = database.GetCollection<BsonDocument>("players");
        //     var filter = Builders<BsonDocument>.Filter.Gt("skillMoves", 4);
        //     var projection = Builders<BsonDocument>.Projection.Exclude("_id");
        //     var results = collection.Find(filter).Project(projection);
        //     int count = (int)results.Count();
        //     Assert.AreNotEqual(0, count);

        // }
        // [Fact]
        // public void CanIterateOverCollection()
        // {
        //     //BsonClassMap.RegisterClassMap<Player>();
        //     var client = new MongoClient(System.Configuration.ConfigurationManager.ConnectionStrings["local"].ConnectionString);
        //     var database = client.GetDatabase("local");
        //     var collection = database.GetCollection<BsonDocument>("players");
        //     var filter = Builders<BsonDocument>.Filter.Gt("skillMoves", 4);
        //     var projection = Builders<BsonDocument>.Projection.Exclude("_id").Exclude("id");
        //     var results = collection.Find(filter).Project(projection);
        //     foreach (var record in results.ToEnumerable())
        //     {
        //         BsonClassMap.RegisterClassMap(Mappers.playerMapper);
        //         Player deserialized = BsonSerializer.Deserialize<Player>(record);
        //         Assert.IsNotNull(deserialized);
        //     }

        // }
    }
}