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
    public class FUTNation
    {
        public Nation Nation;
        public List<Player> players;

        public FUTNation(int id)
        {
            FUTNationDAL DAL = new FUTNationDAL();
            var tmp = DAL.GetNation(id);   
            Nation = tmp.Nation;
            players = tmp.players;
        }

        public FUTNation()
        {
            players = new List<Player>();
        }

        public List<Player> GetPlayers()
        {
            return players;
        }
    }


    public class FUTNationDAL 
    {
        public const string LocalConnection = "mongodb://localhost:27017";
        public const string RemoteConnection = "mongodb://root:futmon@mongo.peterfutdb.com/admin";
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        MongoCollection _collection;


        public FUTNationDAL()
        {
            //this.Nation = new Nation();
            _client = new MongoClient(LocalConnection);
            _server = _client.GetServer();
            _db = _server.GetDatabase("local");      
            _collection = _db.GetCollection<FUTNation>("players");
        }
        public FUTNation GetNation(int NationID)
        {
            var res = Query<Player>.EQ(p=>p.nation.nationid,NationID);
            var players = _collection.FindAs<Player>(res).ToList();
            FUTNation tmp = new FUTNation();
            tmp.players = players;
            if (players.Count > 0)
            {
                tmp.Nation = players[0].nation;
                return tmp;
            }
            return null;
        }


    }
 

}