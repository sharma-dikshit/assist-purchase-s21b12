using System.Collections.Generic;
using AssistPurchase.Models;
using Microsoft.AspNetCore.Mvc;


namespace AssistPurchase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoringProductController : ControllerBase
    {
        private readonly Repository.IMonitoringDataRepository _productDataRepository;

        public MonitoringProductController(Repository.IMonitoringDataRepository productRepo)
        {
            _productDataRepository = productRepo;
        }


        // GET: api/<MonitoringProductController>
        [HttpGet("all")]
        public IEnumerable<MonitoringProducts> Get()
        {
            return _productDataRepository.GetAllProducts();
        }

        // GET api/<MonitoringProductController>/5
        [HttpGet("get/{productNumber}")]
        public ActionResult<IEnumerable<MonitoringProducts>> Get(string productNumber)
        {
            var product = _productDataRepository.FindProduct(productNumber);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST api/<MonitoringProductController>
        [HttpPost("new")]
        public void Post([FromBody] MonitoringProducts product)
        {
            _productDataRepository.AddNewProduct(product);
        }

        // PUT api/<MonitoringProductController>/5
        [HttpPut("update/{productNumber}")]
        public ActionResult Put(string productNumber, [FromBody] MonitoringProducts product)
        {
            var findProduct = _productDataRepository.FindProduct(productNumber);
            try
            {
                if (findProduct != null)
                {
                    _productDataRepository.UpdateProduct(product);
                   
                }
                return Ok();
            }
            catch
            {
                return NotFound();
               
            }

        }

        // DELETE api/<MonitoringProductController>/5
        [HttpDelete("delete/{productNumber}")]
        public ActionResult Delete(string productNumber)
        {
            var findProduct = _productDataRepository.FindProduct(productNumber);
            try
            {
                if (findProduct != null)
                {
                    _productDataRepository.RemoveProduct(productNumber);

                }
                return Ok();
            }
            catch
            {
                return NotFound();

            }
        }
    }
}
