using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.Shipping
{
    public interface IShippingService
    {
        void CreateSlip();
        void CreateDuplicateSlip();
        void CreateSlipWithVideo(object content);
    }

    public class ShippingService : IShippingService
    {
        public void CreateDuplicateSlip()
        {
            //throw new NotImplementedException();
        }

        public void CreateSlip()
        {
            //throw new NotImplementedException();
        }

        public void CreateSlipWithVideo(object content)
        {

        }
    }
}
