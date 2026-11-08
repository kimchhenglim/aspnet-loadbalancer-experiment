using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlashlightCinema.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoadBalancerTestController : ControllerBase
    {
        public IActionResult Get()
        {
            var data = System.Text.Encoding.UTF8.GetBytes("flashlight");
            int count = 0;
            for (int i = 0; i < 20000; i++)
            {
                data = System.Security.Cryptography.SHA256.HashData(data);
                count++;
            }
            return Ok($"Looped {count} times and the result of hash data is " + Convert.ToHexString(data));
        }
    }
}
