using AssistPurchase.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssistPurchase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAlertController : ControllerBase
    {
        private readonly Repository.ICustomerAlertRepository _customerAlertRepository;

        public CustomerAlertController(Repository.ICustomerAlertRepository customerRepo)
        {
            _customerAlertRepository = customerRepo;
        }


        // POST api/<CustomerAlertController>
        [HttpPost("sendAlert")]
        public IActionResult SendAlertActionResult([FromBody] CustomerModel customer)
        {
            try
            {
                _customerAlertRepository.SendEmail(customer);
                return Ok();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPost("CustomerAuthenticate/{productName}/{customerId}")]
        public IActionResult CustomerAuthenticate(string productName, string customerId, [FromBody] CustomerModel customer)
        {
           
            var customerDetails = _customerAlertRepository.FindCustomer(customerId);
            if (customerDetails == null)
            {
                _customerAlertRepository.AddCustomer(customer);
                return Ok("New Customer");
            }
            
            customerDetails.ProductName = productName; 
            _customerAlertRepository.AddCustomer(customer);
            return Ok("Existing Customer");
        }
    }
}
