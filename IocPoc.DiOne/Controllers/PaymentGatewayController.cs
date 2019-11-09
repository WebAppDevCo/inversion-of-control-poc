using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IocPoc.DiOne.Controllers
{
    [RoutePrefix("api/payment-gateway")]
    public class PaymentGatewayController : ApiController
    {
        private readonly Domain.IPaymentGateway PaymentGateway;

        public PaymentGatewayController(Domain.IPaymentGateway paymentGateway)
        {
            PaymentGateway = paymentGateway;
        }

        [HttpGet]
        [Route("name")]
        public string GetGatewayName()
        {
            return PaymentGateway.GatewayName;
        }
    }
}
