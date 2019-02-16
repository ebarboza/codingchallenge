using CodingChallenge.WebApi.Services;
using System.Web.Http;

namespace CodingChallenge.WebApi.Controllers
{
    [Route("api/user")]
    public class UserController : ApiController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        //GET: api/user
        [HttpGet]
        [Route("api/user")]
        public IHttpActionResult Get()
        {
            var result = userService.GetUsers();
            return Ok(result);
        }
    }
}