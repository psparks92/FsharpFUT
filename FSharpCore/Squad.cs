

using System.Collections.Generic; 
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using System.Linq;
using Microsoft.Extensions.Configuration;


namespace FSharpFUT.API
{
    public class Squad
    {
        public string Name;
        public string Owner;
        public string Formation;
        public Player player1;
        public Player player2;
        public Player player3;
        public Player player4;
        public Player player5;
        public Player player6;
        public Player player7;
        public Player player8;
        public Player player9;
        public Player player10;
        public Player player11;

    }


    public class SquadDAL 
    {
        public const string LocalConnection = "mongodb://localhost:27017";
        public const string RemoteConnection = "mongodb://root:futmon@mongo.peterfutdb.com/admin";
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        MongoCollection _collection;


        public SquadDAL()
        {
            _client = new MongoClient(RemoteConnection);
            _server = _client.GetServer();
            _db = _server.GetDatabase("local");      
            _collection = _db.GetCollection<Squad>("squads");
        }

        public Squad Create(Squad c)
        {
            _db.GetCollection<Squad>("squads").Save(c);
            return c;
        }

        public List<Squad> GetSquads()
        {
            var filter = Query<Squad>.NE(q => q.Name, "");
            var projection = Builders<Squad>.Projection.Exclude("_id");
            var results = _collection.FindAs<Squad>(filter);
            return results.ToList();
        }
    }
 

}