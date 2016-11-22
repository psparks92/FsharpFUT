
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
    public class FUTClub
    {
        public string name;
        public string owner;
        public List<Player> players;
    }


    public class FUTClubDAL 
    {
        public const string LocalConnection = "mongodb://localhost:27017";
        public const string RemoteConnection = "mongodb://root:futmon@mongo.peterfutdb.com/admin";
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        MongoCollection _collection;


        public FUTClubDAL()
        {
            _client = new MongoClient(RemoteConnection);
            _server = _client.GetServer();
            _db = _server.GetDatabase("local");      
            _collection = _db.GetCollection<FUTClub>("clubs");
        }

        public FUTClub Create(FUTClub c)
        {
            _db.GetCollection<FUTClub>("clubs").Save(c);
            return c;
        }

    }
 

}