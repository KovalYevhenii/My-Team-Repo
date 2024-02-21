using Microsoft.AspNetCore.Mvc;
namespace GServer.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        [HttpGet("Session")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public ActionResult<Dictionary<string, bool>> GetSession([FromQuery] long chatId)
        {
            try
            {
                Dictionary<string, bool> result;
                Console.WriteLine(chatId);
                // Simulate getting session from the database
                if (chatId != 0)
                {
                    // If there's no chatId in the session, simulate creating a new session
                    result = new Dictionary<string, bool> { { "sessionId", true } };  
                }
                else
                {//simulate getting existing session
                    result = new Dictionary<string, bool> { { "sessionExists", true } };
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
