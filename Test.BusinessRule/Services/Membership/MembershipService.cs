using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.Services.Membership
{
    public interface IMembershipService
    {
        bool Activate();
        bool Upgrade();
    }

    public class MembershipService : IMembershipService
    {
        public bool Activate()
        {
            return true;
        }

        public bool Upgrade()
        {
            return true;
        }
    }
}
