using EFCoreInMemory.Models.RequestModel;
using EFCoreInMemory.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreInMemory.Controllers;

public class CustomerController : Controller
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpGet]
    [Route("/api/v1/customer")]
    public async Task<IActionResult> GetCustomers()
    {
        return Ok(await _customerRepository.GetCustomers());
    }

    [HttpPost]
    [Route("/api/v1/customer")]
    public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequestModel requestModel)
    {
        if (string.IsNullOrEmpty(requestModel.CustomerName))
            return BadRequest();

        if (string.IsNullOrEmpty(requestModel.Email))
            return BadRequest();

        if (requestModel.Age == 0)
            return BadRequest();

        int result = await _customerRepository.CreateCustomer(requestModel);

        return result > 0 ? StatusCode(StatusCodes.Status201Created, "Creating Successful!") : BadRequest("Creating Fail!");
    }
}