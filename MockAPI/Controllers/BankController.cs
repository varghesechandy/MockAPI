using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAPI.Model;

namespace MockAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankController : ControllerBase
    {
        [HttpPost]
        public IEnumerable<string> Get([FromBody] PaymentData paymentData)
        {
            var statusCode = paymentData.Name.ToLower().Contains("fail") ? "20120" : paymentData.Name.ToLower().Contains("block") ? "40101" : paymentData.Name.ToLower().Contains("nofund") ? "200P9" : "10000";
            var statusMessage = paymentData.Name.ToLower().Contains("fail") ? "Invalid Customer/User! Your payment request was unsuccessful." :
                                paymentData.Name.ToLower().Contains("block") ? "The request was blocked by your risk settings! Your payment request was unsuccessful." :
                                paymentData.Name.ToLower().Contains("nofund") ? "Limit exceeded! Enter a lesser value. Your payment request was unsuccessful." :
                                "Your payment request was successful.";

            return new string[] { Guid.NewGuid().ToString(), statusCode, statusMessage };
        }
    }
}
