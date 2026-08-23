using BLL.Models;
using BLL.Services;
using DAL.EF.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService service;

        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var data = service.GetAllEmployees();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var data = service.GetEmployeeById(id);
            return Ok(data);
        }
        [HttpPost("create")]
        public IActionResult Create(EmployeeModel e)
        { 
            var data = service.CreateEmployee(e);
            return Ok(data);
        }
        [HttpPost("delete")]
        public IActionResult DeleteEmployee(int id)
        {
            var data = service.DeleteEmployee(id);
            return Ok(data);
        }
        [HttpPost("update")]
        public IActionResult UpdateEmployee(EmployeeModel e)
        {
            var data = service.UpdateEmployee(e);
            return Ok(data);
        }
    }
}
