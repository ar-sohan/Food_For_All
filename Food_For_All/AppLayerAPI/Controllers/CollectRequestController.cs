using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectRequestController : ControllerBase
    {
        CollectRequestService crs;
        public CollectRequestController(CollectRequestService crs)
        {
            this.crs = crs;
        }

        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            var result = crs.GetAllCollectRequests();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult AddCollectRequest(CollectRequestModel collectRequestModel)
        {
            var result = crs.AddCollectRequest(collectRequestModel);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("accept")]
        public IActionResult UpdateCollectRequest(CollectRequestModel collectRequestModel)
        {
            var result = crs.UpdateCollectRequest(collectRequestModel);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}
