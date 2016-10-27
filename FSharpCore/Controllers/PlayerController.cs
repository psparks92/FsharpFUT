using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
//using System.Linq.Queryable;
using FSharpFUT.API;

namespace FSharpFUT.API.Controllers
{
    [Route("api/[controller]")]
    public class PlayerController : Controller
    {
        private static Player _player;
        static PlayerController()
        {
            _player = new Player();
        }

        [HttpGet("{id}", Name = "GetById")]
        public Player GetById(string id)
        {
            return Player.GetById(id);
        }
    }
}