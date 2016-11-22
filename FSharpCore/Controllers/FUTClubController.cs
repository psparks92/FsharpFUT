
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
    public class FUTClubsController : Controller
    {
        private static List<FUTClub> _players;
        static FUTClubsController()
        {
            _players = new List<FUTClub>();
        }

        [HttpGet]
        public IEnumerable<FUTClub> GetAll()
        {
            return FUTClub.GetAll();
        }

        [HttpGet("myclubs/{name}", Name = "GetMyClubs")]
        public IEnumerable<FUTClub> GetMyClubs(string name)
        {
            return FUTClub.GetMyClubs(name);
        }

        [HttpGet("{name}", Name = "GetByName")]
        public FUTClub GetByName(string name)
        {
            return FUTClub.GetByName(name);
        }
        
    }
}
