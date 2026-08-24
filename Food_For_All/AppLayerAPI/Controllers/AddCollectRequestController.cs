using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCollectRequestController : ControllerBase
    {
        CollectRequestService crs;
        public AddCollectRequestController(CollectRequestService crs)
        {
            this.crs = crs;
        }

        [HttpPost("add")]
        public IActionResult AddCollectRequest(CollectRequestModel collectRequestModel)
        {
            var result = crs.AddCollectRequest(collectRequestModel);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
