using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Cors;
//using System.Linq.Queryable;
using FSharpFUT.API;

namespace FSharpFUT.API.Controllers
{
    [EnableCors("AllowAll")]
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

        [HttpGet("Club/{id}", Name = "GetPlayersFromClub")]
        public IEnumerable<Player> GetPlayersFromClub(int id) 
        {
            return Player.GetFromClub(id);
        }
        
    }
}
