using Homes.EntryPoint.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Homes.EntryPoint.Controllers
{
    [ApiController]
    [Route("/api/v1")]
    public class PropertiesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<PropertiesController> _logger;

        public PropertiesController(ILogger<PropertiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/properties")]
        public IEnumerable<Property> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Property
            {
            })
            .ToArray();
        }

        [HttpPost("/properties")]
        public Property InsertProperty()
        {
            return null;
        }
    }
}