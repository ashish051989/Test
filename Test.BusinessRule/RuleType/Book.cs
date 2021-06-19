using System;
using System.Collections.Generic;
using System.Text;
using Test.BusinessRule.Services.PaymentService;
using Test.BusinessRule.Services.Shipping;

namespace Test.BusinessRule.RuleType
{
    public class Book : IRuleType
    {
        private readonly IShippingService _shippingService;
        private readonly IPaymentService _paymentService;

        public Book(IShippingService shippingService,
            IPaymentService paymentService)
        {
            _shippingService = shippingService;
            _paymentService = paymentService;
        }

        public string RuleType => nameof(Book);

        public void ApplyRule()
        {
            _shippingService.CreateDuplicateSlip();
            _paymentService.GenerateCommission();
        }
    }
}
