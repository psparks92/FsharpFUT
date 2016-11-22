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
    

    [BsonIgnoreExtraElements]
    public class Headshot
    {
        public string medImgUrl { get; set; }
        public string smallImgUrl { get; set; }
        public string largeImgUrl { get; set; }
    }

[BsonIgnoreExtraElements]
    public class Dark
    {
        public string small { get; set; }
        public string large { get; set; }
        public string medium { get; set; }
    }

[BsonIgnoreExtraElements]
    public class Normal
    {
        public string small { get; set; }
        public string large { get; set; }
        public string medium { get; set; }
    }

[BsonIgnoreExtraElements]
    public class ImageUrls
    {
        public Dark dark { get; set; }
        public Normal normal { get; set; }
    }

[BsonIgnoreExtraElements]
    public class Club
    {
        public string abbrName { get; set; }
        public ImageUrls imageUrls { get; set; }
        public int clubid { get; set; }
        public object imgUrl { get; set; }
        public string name { get; set; }
    }

[BsonIgnoreExtraElements]
    public class SmallClub
    {
        public string abbrName { get; set; }
        public int clubid { get; set; }
        public string name { get; set; }
    }

[BsonIgnoreExtraElements]
    public class ImageUrls2
    {
        public string small { get; set; }
        public string large { get; set; }
        public string medium { get; set; }
    }

[BsonIgnoreExtraElements]
    public class Nation
    {
        public string abbrName { get; set; }
        public ImageUrls2 imageUrls { get; set; }
        public int nationid { get; set; }
        public object imgUrl { get; set; }
        public string name { get; set; }
    }

[BsonIgnoreExtraElements]
    public class SmallNation
    {
        public string abbrName { get; set; }
        public int nationid { get; set; }
        public string name { get; set; }
    }

[BsonIgnoreExtraElements]
    public class Attribute
    {
        public string name { get; set; }
        public int value { get; set; }
        public List<int> chemistryBonus { get; set; }
    }

[BsonIgnoreExtraElements]
    public class SmallAttribute
    {
        public string name { get; set; }
        public int value { get; set; }
    }

[BsonIgnoreExtraElements]
    public class League
    {
        public string abbrName { get; set; }
        public int leagueid { get; set; }
        public object imgUrl { get; set; }
        public string name { get; set; }
    }
[BsonIgnoreExtraElements]
    public class SmallLeague
    {
        public string abbrName { get; set; }
        public int leagueid { get; set; }
        public string name { get; set; }
    }

[BsonIgnoreExtraElements]
    public class SmallPlayer
    {
        public int rating {get; set;}
        public string color {get; set;}
        public string quality {get; set;}
        public int playerid {get; set;}
        public string commonName {get; set;}
        public int baseId {get; set;}
        public SmallClub club {get; set;}
        public SmallNation nation {get; set;}
        public int skillMoves {get; set;}
        public List<SmallAttribute> attributes {get; set;}
        public string playerType {get; set;}
        public SmallLeague league {get; set;}
        public string name {get; set;}
        public string firstName {get; set;}
        public int longshots {get; set;}
        public string lastName {get; set;}
        public string positionFull {get; set;}

    }

[BsonIgnoreExtraElements]
    public class Player
    {
        public int rating { get; set; }
        public string itemType { get; set; }
        public int weight { get; set; }
        public int reactions { get; set; }
        public string color { get; set; }
        public int gkdiving { get; set; }
        public int penalties { get; set; }
        public string atkWorkRate { get; set; }
        public int height { get; set; }
        public List<string> traits { get; set; }
        public bool isGK { get; set; }
        public bool isSpecialType { get; set; }
        public Headshot headshot { get; set; }
        public List<string> specialities { get; set; }
        public string headshotImgUrl { get; set; }
        public string quality { get; set; }
        public string playerid { get; set; }
        public int aggression { get; set; }
        public int freekickaccuracy { get; set; }
        public int acceleration { get; set; }
        public int marking { get; set; }
        public string modelName { get; set; }
        public int gkreflexes { get; set; }
        public int gkhandling { get; set; }
        public int headingaccuracy { get; set; }
        public int dribbling { get; set; }
        public string commonName { get; set; }
        public int stamina { get; set; }
        public int standingtackle { get; set; }
        public int slidingtackle { get; set; }
        public int potential { get; set; }
        public int gkkicking { get; set; }
        public int longpassing { get; set; }
        public int shotpower { get; set; }
        public int sprintspeed { get; set; }
        public int agility { get; set; }
        public string playStyle { get; set; }
        public int positioning { get; set; }
        public int baseId { get; set; }
        public Club club { get; set; }
        public int volleys { get; set; }
        public int price { get; set; }
        public Nation nation { get; set; }
        public int ballcontrol { get; set; }
        public int weakFoot { get; set; }
        public int jumping { get; set; }
        public int skillMoves { get; set; }
        public List<Attribute> attributes { get; set; }
        public string foot { get; set; }
        public int strength { get; set; }
        public string defWorkRate { get; set; }
        public string playerType { get; set; }
        public League league { get; set; }
        public int interceptions { get; set; }
        public int shortpassing { get; set; }
        public int gkpositioning { get; set; }
        public string name { get; set; }
        public string firstName { get; set; }
        public int longshots { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public int curve { get; set; }
        public string birthdate { get; set; }
        public string positionFull { get; set; }
        public int crossing { get; set; }
        public string position { get; set; }
        public int finishing { get; set; }
        public int balance { get; set; }
        public int vision { get; set; }

        public static List<SmallPlayer> Get() 
        {

            PlayerDAL DAL = new PlayerDAL();
            List<SmallPlayer> players = DAL.GetPlayers();
            return players;
        }

        public static List<Player> GetFromClub(int id)
        {

            PlayerDAL DAL = new PlayerDAL();
            return DAL.GetPlayersFromClub(id);
        }

        public static List<Player> GetByName(string name)
        {

            PlayerDAL DAL = new PlayerDAL();
            return DAL.GetPlayers(name);
        }

        public static Player GetById(string id)
        {
            PlayerDAL DAL =new PlayerDAL();
            return DAL.GetPlayer(id);
        }
        
        public static FSharpCalc.FSharpCalc.PlayerInfo GetFSharpPlayerInfo(Player player)
        {
            return new FSharpCalc.FSharpCalc.PlayerInfo(
                FSharpCalc.FSharpCalc.makePosition(player.position),
                player.nation.name,
                player.league.name,
                player.club.name,
                false,
                player.firstName + " " + player.lastName,
                player.rating
            );
        }


}

public class PlayerDAL 
{
    public const string LocalConnection = "mongodb://localhost:27017";
    public const string RemoteConnection = "mongodb://root:futmon@mongo.peterfutdb.com/admin";

    
    MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        MongoCollection _collection;
 
        public PlayerDAL()
        {
            _client = new MongoClient(LocalConnection);
            _server = _client.GetServer();
            _db = _server.GetDatabase("local");      
            _collection = _db.GetCollection<Player>("players");
        }
 
        public List<SmallPlayer> GetPlayers()
        {
            var filter = Query<SmallPlayer>.NE(q => q.playerid, 0);
            var projection = Builders<SmallPlayer>.Projection.Exclude("_id");
            var results = _collection.FindAs<SmallPlayer>(filter);
            return results.ToList().Take(1000).ToList();
        }

        public List<Player> GetPlayersFromClub(int clubId)
        {
            var filter = Query<Player>.EQ(q => q.club.clubid, clubId);
            var projection = Builders<Player>.Projection.Exclude("_id");
            var results = _collection.FindAs<Player>(filter);
            return results.ToList();
        }


 
        public List<Player> GetPlayers(string name)
        {
            string newname = "";
            while (name.Length > 0)
            {
                string first = name.Substring(0,1);
                newname = newname + "[" + first.ToUpper() + first.ToLower() + "]";
                name = name.Substring(1);
            }
            var res = Query.Or(Query<Player>.Matches(p=>p.lastName,".*"+newname+".*"),
               Query<Player>.Matches(p=>p.firstName,".*"+newname+".*"),
               Query<Player>.Matches(p=>p.commonName,".*"+newname+".*"));
            return _collection.FindAs<Player>(res).ToList();
        }
 
        public Player GetPlayer(string id)
        {
            var res = Query<Player>.EQ(p=>p.playerid,id);
            return _collection.FindOneAs<Player>(res);
        }
 
        public Player Create(Player p)
        {
            _db.GetCollection<Player>("players").Save(p);
            return p;
        }
 
        public void Update(string id,Player p)
        {
            p.playerid = id;
            var res = Query<Player>.EQ(pd => pd.playerid,id);
            var operation = Update<Player>.Replace(p);
            _db.GetCollection<Player>("players").Update(res,operation);
        }
        public void Remove(string id)
        {
            var res = Query<Player>.EQ(e => e.playerid, id);
            var operation = _db.GetCollection<Player>("players").Remove(res);
        }

}


}