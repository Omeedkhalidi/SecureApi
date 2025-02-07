using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SecureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        [HttpGet("encrypt")]
        public ActionResult<string> Encrypt([FromQuery] string input, [FromQuery] int shift)
        {
            var encrypted = new string(input.Select(c => (char)(c + shift)).ToArray());
            return Ok(encrypted);
        }

        [HttpGet("decrypt")]
        public ActionResult<string> Decrypt([FromQuery] string input, [FromQuery] int shift)
        {
            var decrypted = new string(input.Select(c => (char)(c - shift)).ToArray());
            return Ok(decrypted);
        }
    }
}
