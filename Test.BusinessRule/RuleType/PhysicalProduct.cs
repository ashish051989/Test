using System;
using Test.BusinessRule.Services.Email;
using Test.BusinessRule.Services.Membership;
using Test.BusinessRule.Services.PaymentService;
using Test.BusinessRule.Services.Shipping;

namespace Test.BusinessRule.RuleType
{
    public class PhysicalProduct : IRuleType
    {
        private readonly IShippingService _shippingService;
        private readonly IPaymentService _paymentService;

        public PhysicalProduct(IShippingService shippingService,
            IPaymentService paymentService)
        {
            _shippingService = shippingService;
            _paymentService = paymentService;
        }

        public string RuleType => nameof(PhysicalProduct);

        public void ApplyRule()
        {
            _shippingService.CreateSlip();
            _paymentService.GenerateCommission();
        }
    } 
}
