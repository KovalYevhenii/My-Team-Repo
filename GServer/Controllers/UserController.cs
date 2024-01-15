using GServer.GameProcess;
using GServer.Handlers;
using GServer.Models.Heroes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace GServer.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("user/[controller]")]
    public class UserController : ControllerBase
    {
        private string sessionid;
        private IHttpContextAccessor _context;
        
        public UserController(IHttpContextAccessor context) {
            _context = context;
            sessionid = _context.HttpContext.Request.Cookies["session"];
        }

        public ActionResult<Dictionary<string, bool>> GetSession(IHttpContextAccessor context)
        {
            Dictionary<string, bool> result = new Dictionary<string, bool>() { };
            try
            {
                string chatId = _context.HttpContext.Request.Cookies["chatid"];
                // По chatId в базу получить сессию
                // Не нашел сессию то должен вернуть sessionId
                // Если он нашел сессию то
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
