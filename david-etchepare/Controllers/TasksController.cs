using Microsoft.AspNetCore.Mvc;

namespace david_etchepare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok();
        }
    }
}
