using GServer.GameProcess;
using GServer.Handlers;
using GServer.Models.Heroes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace GServer.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("game/[controller]")]
    public class GameController : ControllerBase
    {
        private string session;
        private IHttpContextAccessor _context;

        public GameController(IHttpContextAccessor context)
        {
            _context = context;
            session = _context.HttpContext.Request.Cookies["session"];
        }

        [Produces("application/json")]
        [HttpPost, Route("start")]
        public ActionResult<Dictionary<string, HeroType>> StartGame()
        {
            Dictionary<string, HeroType> _response = new Dictionary<string, HeroType>();
            try
            {
                GameHandler.StartGame(session, _response);
                Sessions.getUserSession();

                Hero () {
                    id,HashCode,Type
                }

                _response.Add(HashCode, HeroType);

                return Ok(_response);
            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public ActionResult<Dictionary<string, HeroType>> MonsterPhase()
        {
            try
            {
                List<string> w;
                session.getSession();
                GameHandler.MonsterPhase();
                _response = .Add(HashCode, HeroType);
                return Ok(_response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
