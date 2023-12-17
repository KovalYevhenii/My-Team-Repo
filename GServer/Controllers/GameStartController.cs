using GServer.Models.Heroes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace GServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameStartController : ControllerBase
    {
       private readonly Hero _hero; 

        public GameStartController(Hero hero) {
            this._hero = hero;
        }


        [HttpGet(Name = "StartGame")]
        public Hero Start() {

            //return _hero;
            return new Enchantress();
        }

    }
}
