using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.Membership
{
    public interface IMembershipService
    {
        void Activate();
        void Upgrade();
    }

    public class MembershipService : IMembershipService
    {
        public void Activate()
        {
            throw new NotImplementedException();
        }

        public void Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}
