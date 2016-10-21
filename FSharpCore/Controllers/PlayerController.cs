using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
//using FSharpFUTModels;

namespace FSharpFUT.API.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private static List<Player> _players;
        static PlayerController()
        {
            _players = new List<Player>();
            _players.Add(new Player{Name="Pogba",Rating="88"});
        }

        [HttpGet]
        public IEnumerable<Player> GetAll()
        {
            return _players.AsReadOnly();
        }


        [HttpGet]
        public IEnumerable<Player> GetTest()
        {
            return _players;
        }
    }
    public class Player
    {
        public string Name;
        public string Rating;
    }
}