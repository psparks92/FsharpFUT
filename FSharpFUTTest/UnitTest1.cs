using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using MongoDB.Bson;

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
    }
}
