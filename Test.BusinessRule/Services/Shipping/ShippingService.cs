using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.Shipping
{
    public interface IShippingService
    {
        bool CreateSlip();
        bool CreateDuplicateSlip();
        bool CreateSlipWithVideo(object content);
    }

    public class ShippingService : IShippingService
    {
        public bool CreateDuplicateSlip()
        {
            return true;
        }

        public bool CreateSlip()
        {
            return true;
        }

        public bool CreateSlipWithVideo(object content)
        {
            return true;
        }
    }
}
