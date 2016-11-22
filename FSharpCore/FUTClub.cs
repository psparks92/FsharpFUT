
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


        public FUTClub CreateClub(string clubname, string clubowner)
        {
            FUTClubDAL DAL = new FUTClubDAL();
            return DAL.Create(new FUTClub{name = clubname, owner = clubowner});
        }

        public static List<FUTClub> GetAll()
        {
            FUTClubDAL DAL = new FUTClubDAL();
            return DAL.GetAllClubs();
        }
        
        public FUTClub AddPlayer(int playerid)
        {
            FUTClubDAL DAL = new FUTClubDAL();
            return DAL.AddPlayerToClub(this, playerid);
        }

        public static List<FUTClub> GetMyClubs(string person)
        {
            FUTClubDAL DAL = new FUTClubDAL();
            return DAL.GetMyClubs(person);
        }

        public static FUTClub GetByName(string club)
        {
            FUTClubDAL DAL = new FUTClubDAL();
            return DAL.GetByName(club);
        }


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

        public List<FUTClub> GetAllClubs()
        {
            var filter = Query<FUTClub>.NE(q => q.name,"");
            return _collection.FindAs<FUTClub>(filter).ToList();
        }

        public FUTClub GetByName(string name)
        {

            var filter = Query<FUTClub>.EQ(q => q.name,name);
            return _collection.FindOneAs<FUTClub>(filter);
        }

        public List<FUTClub> GetMyClubs(string person)
        {

            var filter = Query<FUTClub>.EQ(q => q.owner,person);
            return _collection.FindAs<FUTClub>(filter).ToList();
        }

        public FUTClub Create(FUTClub c)
        {
            _db.GetCollection<FUTClub>("clubs").Save(c);
            return c;
        }

        public FUTClub AddPlayerToClub(FUTClub club, int playerid)
        {
            Player playerToAdd = Player.GetById(playerid.ToString());
            var filter = Query<FUTClub>.EQ(q => q.name,club.name);
            var update = Update.Push("players", playerToAdd.ToBson());
            _db.GetCollection<FUTClub>("clubs").Update(filter,update);
            club.players.Add(playerToAdd);
            return club;
        }

    }
 

}