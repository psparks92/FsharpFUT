using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace FSharpFUTService.Models
{
    public static class Mappers
    {
        public static BsonClassMap playerMapper
        {
            get
            {
                BsonClassMap map = new BsonClassMap(typeof(Player));
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapMember(typeof(Player).GetProperty("id")).SetElementName("id");
                return map;
            }
        }
    }
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
        public int id { get; set; }
        public object imgUrl { get; set; }
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
        public int id { get; set; }
        public object imgUrl { get; set; }
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
    public class League
    {
        public string abbrName { get; set; }
        public int id { get; set; }
        public object imgUrl { get; set; }
        public string name { get; set; }
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
        public string id { get; set; }
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




    }


}