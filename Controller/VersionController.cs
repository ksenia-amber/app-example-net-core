using Microsoft.AspNetCore.Mvc;

namespace app_example_net_core.Controller;

[ApiController]
[Route("[controller]")]
public class VersionController() : ControllerBase
{
   [HttpGet(Name = "/version")]
    public ObjectResult GetVersion()
    {
        return Ok(GetType().Assembly.GetName().Version);
    }
}