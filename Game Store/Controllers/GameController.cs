using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game_Store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Game_Store.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetGames()
        {
            return new List<Game>
            {
                new Game
                {
                    Name="Shadow of the Tomb Raider",
                    Description="Game of the year.",
                    ReleaseDate=DateTime.Now
                }
            };
        }
    }
}
