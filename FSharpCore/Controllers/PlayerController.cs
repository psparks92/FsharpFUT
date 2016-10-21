using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//using System.Linq.Queryable;
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


        [HttpGet("{name}", Name = "GetByName")]
        public IEnumerable<Player> GetByName(string name)
        {
            return _players.Where(q => q.Name.Contains(name)).ToList();
        }
    }
    public class Player
    {
        public string Name;
        public string Rating;
    }
}