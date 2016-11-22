
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
    public class FUTLeague
    {
        public League League;
        public List<Player> players;

        public FUTLeague(int id)
        {
            FUTLeagueDAL DAL = new FUTLeagueDAL();
            var tmp = DAL.GetLeague(id);   
            League = tmp.League;
            players = tmp.players;
        }

        public FUTLeague()
        {
            players = new List<Player>();
        }

        public List<Player> GetPlayers()
        {
            return players;
        }
    }


    public class FUTLeagueDAL 
    {
        public const string LocalConnection = "mongodb://localhost:27017";
        public const string RemoteConnection = "mongodb://root:futmon@mongo.peterfutdb.com/admin";
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        MongoCollection _collection;


        public FUTLeagueDAL()
        {
            //this.League = new League();
            _client = new MongoClient(RemoteConnection);
            _server = _client.GetServer();
            _db = _server.GetDatabase("local");      
            _collection = _db.GetCollection<FUTLeague>("players");
        }
        public FUTLeague GetLeague(int LeagueID)
        {
            var res = Query<Player>.EQ(p=>p.league.leagueid,LeagueID);
            var players = _collection.FindAs<Player>(res).ToList();
            FUTLeague tmp = new FUTLeague();
            tmp.players = players;
            if (players.Count > 0)
            {
                tmp.League = players[0].league;
                return tmp;
            }
            return null;
        }


    }
 

}