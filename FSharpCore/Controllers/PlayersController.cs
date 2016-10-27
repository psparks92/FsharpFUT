using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//using System.Linq.Queryable;
using FSharpFUT.API;

namespace FSharpFUT.API.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private static List<Player> _players;
        static PlayersController()
        {
            _players = new List<Player>();
        }

        [HttpGet]
        public IEnumerable<Player> GetAll()
        {
            
            return Player.Get();
        }


        [HttpGet("{name}", Name = "GetByName")]
        public IEnumerable<Player> GetByName(string name)
        {
                return Player.GetByName(name);
        }
        
    }
}