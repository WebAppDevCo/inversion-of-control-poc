using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizeDotNet
{
    internal class PaymentGateway : IocPoc.Domain.IPaymentGateway
    {
        public string GatewayName { get; private set; }

        public PaymentGateway()
        {
            GatewayName = "AuthorizeDotNet";
        }
    }
}
