using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurentController : ControllerBase
    {
        RestaurentService rs;
        public RestaurentController(RestaurentService rs)
        {
            this.rs = rs;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllRestaurents()
        {
            var restaurents = rs.GetAllRestaurents();
            return Ok(restaurents);
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurentById(int id)
        {
            var restaurent = rs.GetRestaurentById(id);
            if (restaurent == null)
            {
                return NotFound();
            }
            return Ok(restaurent);
        }

        [HttpPost("add")]
        public IActionResult AddRestaurent(RestaurentModel restaurentModel)
        {
            var result = rs.AddRestaurent(restaurentModel);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}