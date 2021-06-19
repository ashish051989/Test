using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.PaymentService
{
    public interface IPaymentService
    {
        void GenerateCommission();
    }

    public class PaymentService : IPaymentService
    {
        public void GenerateCommission()
        {
            throw new NotImplementedException();
        }
    }
}
