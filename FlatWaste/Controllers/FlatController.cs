using Microsoft.AspNetCore.Mvc;

namespace FlatWaste.Controllers
{
    [ApiController]
    [Route("api/flat")]
    public class FlatController: ControllerBase
    {
        public ActionResult Home()
        {
            return Ok();
        }
    }
}
