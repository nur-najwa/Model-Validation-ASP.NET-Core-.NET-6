using Microsoft.AspNetCore.Mvc;
using ModelValidationAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModelValidationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public ActionResult <User> Post([FromBody] User user)
        {
            //Some Operations
            return Ok(user);
        }

    }
}
