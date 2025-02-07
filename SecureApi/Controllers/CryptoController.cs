using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SecureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        [HttpPost("encrypt")]
        public ActionResult<string> Encrypt([FromBody] CryptoRequest request)
        {
            var encrypted = new string(request.Text.Select(c => (char)(c + request.Shift)).ToArray());
            return Ok(encrypted);
        }

        [HttpPost("decrypt")]
        public ActionResult<string> Decrypt([FromBody] CryptoRequest request)
        {
            var decrypted = new string(request.Text.Select(c => (char)(c - request.Shift)).ToArray());
            return Ok(decrypted);
        }
    }

    public class CryptoRequest
    {
        public string Text { get; set; }
        public int Shift { get; set; }
    }
}
