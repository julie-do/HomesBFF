using Homes.EntryPoint.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using Homes.BLL;

namespace Homes.EntryPoint.Controllers
{
    [ApiController]
    [Route("/api/v1")]
    public class PropertiesController : ControllerBase
    {
        private readonly ILogger<PropertiesController> _logger;
        private readonly IGetPropertyService _getPropertyService;

        public PropertiesController(ILogger<PropertiesController> logger, IGetPropertyService getPropertyService)
        {

            _logger = logger;
            _getPropertyService = getPropertyService;
        }

        [HttpGet("/properties")]
        public IEnumerable<Property>? Get()
        {
            var properties = _getPropertyService.GetProperties();
            return properties?.Select(property => new Property());
        }

        [HttpPost("/properties")]
        public Property InsertProperty()
        {
            _logger.LogInformation("poco");
            return null;
        }
    }
}