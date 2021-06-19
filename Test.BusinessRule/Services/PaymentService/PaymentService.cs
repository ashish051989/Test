using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.PaymentService
{
    public interface IPaymentService
    {
        bool GenerateCommission();
    }

    public class PaymentService : IPaymentService
    {
        public bool GenerateCommission()
        {
            return true;
        }
    }
}
