using System;
using System.Collections.Generic;
using System.Text;
using Test.BusinessRule.Services.Shipping;

namespace Test.BusinessRule.RuleType
{
    public class Video : IRuleType
    {
        private readonly IShippingService _shippingService;

        public Video(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }

        public string RuleType => nameof(Video);

        public void ApplyRule()
        {
            var videoContent = new object();
            _shippingService.CreateSlipWithVideo(videoContent);

            //throw new NotImplementedException();
        }
    }
}
