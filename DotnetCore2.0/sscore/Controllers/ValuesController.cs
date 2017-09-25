using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Steeltoe.Discovery.Client;

namespace sscore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DiscoveryHttpClientHandler _handler;
        private const string ProductUrl = "http://product/api/values";

        public ValuesController(IDiscoveryClient client, ILoggerFactory logFactory)
        {
            _handler = new DiscoveryHttpClientHandler(client);
        }

        // http://ip:port/api/values/cloud
        [HttpGet("cloud")]
        public async Task<string> GoProductAsync()
        {
            var client = new HttpClient(_handler, false);
            return await client.GetStringAsync(ProductUrl);
        }
         
    }
}
