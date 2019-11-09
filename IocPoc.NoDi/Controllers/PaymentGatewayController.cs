using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IocPoc.NoDi.Controllers
{
    [RoutePrefix("api/payment-gateway")]
    public class PaymentGatewayController : ApiController
    {
        [HttpGet]
        [Route("name")]
        public string GetGatewayName()
        {
            var payPal = new PayPal.PaymentGateway();
            
            return payPal.GatewayName;
        }
    }
}
