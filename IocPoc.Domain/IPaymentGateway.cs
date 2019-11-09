using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocPoc.Domain
{
    public interface IPaymentGateway
    {
        string GatewayName { get; }
    }
}
