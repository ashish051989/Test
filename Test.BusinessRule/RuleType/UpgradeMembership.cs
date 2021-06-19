using System;
using System.Collections.Generic;
using System.Text;
using Test.BusinessRule.Services.Email;
using Test.BusinessRule.Services.Membership;

namespace Test.BusinessRule.RuleType
{
    public class UpgradeMembership : IRuleType
    {
        private readonly IMembershipService _membershipService;
        private readonly IEmailService _emailService;

        public UpgradeMembership(IMembershipService membershipService,
            IEmailService emailService)
        {
            _membershipService = membershipService;
            _emailService = emailService;
        }

        public string RuleType => nameof(UpgradeMembership);

        public void ApplyRule()
        {
            _membershipService.Upgrade();
            _emailService.Notify();
        }
    }
}
