using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionController : ControllerBase
    {
        DistributionService ds;

        public DistributionController(DistributionService ds)
        {
            this.ds = ds;
        }

        [HttpGet("getall")]
        public IActionResult GetAllDistributions()
        {
            var data = ds.GetAllDistributions();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult GetDistribution(int id) {
            var data = ds.GetDistributionById(id);
            return Ok(data);
        }
        [HttpPost("add")]
        public IActionResult AddDistribution(DistributionModel distributionModel)
        {
            var result = ds.AddDistribution(distributionModel);
            if (result)
            {
                return Ok("Distribution added successfully.");
            }
            return BadRequest("Failed to add distribution.");
        }
    }
}
