using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet ("getAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            return Ok(await _employeeService.GetAllEmployees());
        }

        [HttpGet]
        [Route("getEmployeeById/{id:guid}")]
        public async Task<IActionResult> GetEmployeeById(Guid id)
        {
            var result = await _employeeService.GetEmployeeById(id);
            if(result == null)
            {
                return NotFound("Id Not Found!!");
            }
            return Ok(result);
        }

        [HttpPost("addEmployee")]
        public async Task<IActionResult> AddEmloyee(AddEmployee addEmployee)
        {
            var result= await _employeeService.AddEmloyee(addEmployee);
            return Ok(result);
        }
        [HttpPut]
        [Route("{id:guid}", Name ="update")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id,UpdateEmployee updateEmployee)
        {
            var result = await _employeeService.UpdateEmloyee(id,updateEmployee);
            if (result == null)
            {
                return NotFound("Id Not Found!!");
            }
            return Ok(result);
        }
        [HttpDelete]
        [Route("{id:guid}", Name = "deleteEmployeeById")]

        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
           var result = await _employeeService.DeleteEmloyee(id);
            if (result == null)
            {
                return NotFound("Id Not Found!!");
            }
            return Ok(result);
        }
        [HttpGet("search")]
        public async Task<IActionResult> search(string name)
        {
            try
            {
                var result = await _employeeService.search(name);
                if(result != null)
                {
                    return Ok(result);
                }
                return NotFound("not found");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
