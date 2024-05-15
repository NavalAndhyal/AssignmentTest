using AssignmentTest.Application.IService;
using AssignmentTest.Domain.Dto;
using AssignmentTest.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssignmentTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [Authorize]
        [HttpPost("GetCustomers")]
        public async Task<IActionResult> GetCustomers([FromBody] CustomerFilterDto customerFilterDto)
        {
            try
            {
                var result = await _customerService.Get(customerFilterDto);
                return Ok(result);

            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // POST api/<CustomerController>
        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _customerService.Create(customer);
                    return Ok(result);
                }
                else
                {
                    return Problem("Validation Error");
                }
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // POST api/<CustomerController>
        [HttpPost("UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerUpdateDto customerUpdateDto)
        {
            try
            {
                var result = await _customerService.Update(customerUpdateDto);
                if (result == null)
                    return NotFound("User Not Found");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            try
            {
                var result = await _customerService.Delete(id);
                if (!result)
                    return NotFound("User Not Found");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
