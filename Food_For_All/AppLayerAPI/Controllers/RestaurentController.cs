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

        
    }
}
