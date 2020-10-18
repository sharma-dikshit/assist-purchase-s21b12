using System.Collections.Generic;
using AssistPurchase.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssistPurchase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientQuestionsController : ControllerBase
    {
        private readonly Repository.IClientQuestions _clientQuestionsRepository;

        public ClientQuestionsController(Repository.IClientQuestions clientRepo)
        {
            _clientQuestionsRepository = clientRepo;
        }

        // GET: api/<ClientQuestionsController>
        [HttpGet("MonitoringProducts")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetProducts()
        {
            var products = _clientQuestionsRepository.GetProducts();
            return Ok(products);
        }

        // GET api/<ClientQuestionsController>/5
        [HttpGet("MonitoringProducts/Description/{productNumber}")]
        public ActionResult GetProductDescription(string productNumber)
        {
            var description = _clientQuestionsRepository.GetProductDescription(productNumber);
            return Ok(description);
        }

        [HttpGet("MonitoringProducts/TouchScreen/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetTouchScreenProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductTouchScreenFeature(value));
        }

        [HttpGet("MonitoringProducts/WearableMonitor/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetWearableMonitorProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductWearableMonitorFeature(value));
        }

        [HttpGet("MonitoringProducts/AlarmManagement/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetAlarmManagementProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductAlarmManagement(value));
        }

        [HttpGet("MonitoringProducts/BelowPrice/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetBelowPriceProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductBelowPrice(value));
        }

        [HttpGet("MonitoringProducts/AbovePrice/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetAbovePriceProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductAbovePrice(value));
        }

        [HttpGet("MonitoringProducts/BelowScreenSize/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetBelowScreenSizeProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductBelowScreenSize(value));
        }

        [HttpGet("MonitoringProducts/AboveScreenSize/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetAboveScreenSizeProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductAboveScreenSize(value));
        }

        [HttpGet("MonitoringProducts/ConnectivitySupport/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetConnectivitySupportProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductConnectivitySupport(value));
        }

        [HttpGet("MonitoringProducts/SummarizeDataSupport/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetSummarizeDataSupportProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductSummarizeDataSupport(value));
        }

        [HttpGet("MonitoringProducts/ScalableMeasurement/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetScalableMeasurementsProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductScalableMeasurementSupport(value));
        }

        [HttpGet("MonitoringProducts/Compact/{value}")]
        public ActionResult<IEnumerable<MonitoringProducts>> GetCompactProducts(string value)
        {
            return Ok(_clientQuestionsRepository.GetProductCompactFeature(value));
        }
    }
}
