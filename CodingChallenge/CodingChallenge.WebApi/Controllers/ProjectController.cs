using CodingChallenge.WebApi.Services;
using System.Web.Http;

namespace CodingChallenge.WebApi.Controllers
{
    [Route("api/project")]
    public class ProjectController : ApiController
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        //GET: api/project/{userId}
        [HttpGet]
        [Route("api/project/{userId}")]
        public IHttpActionResult Get(int userId)
        {
            var result = projectService.GetProject(userId);
            return Ok(result);
        }
    }
}