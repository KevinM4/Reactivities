using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //This Controller was made so that other Controllers can derive from this Controller (class),
    //so that the basic parts of a controller ([ApiController] and Route) doesnt have to be typed everytime in the controller itself.

    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}