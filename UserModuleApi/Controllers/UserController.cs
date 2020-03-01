using Microsoft.AspNetCore.Mvc;

namespace UserModuleApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("yo")]     
        public string GetUser()
        {
            return "user";
        }
    }
}