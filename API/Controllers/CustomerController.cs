using DOMAIN.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CustomerController : ControllerBase
{
    [Route("Customer")]
    [HttpGet]
    public async Task<ActionResult<Customer>> GetCustomer()
    {
        return Ok(new Customer());
    }
}