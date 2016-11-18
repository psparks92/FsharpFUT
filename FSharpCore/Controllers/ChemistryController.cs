using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Cors;
//using System.Linq.Queryable;
using FSharpCalc;
using FSharpFUT.API;

namespace FSharpFUT.API.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    public class Chemistry : Controller
    {

        [HttpGet("{id}")]
        public int GetRobbenRating(int id)
        {
            return FSharpInterop.GetRobbenRating(id);
        }

    }

    
}
