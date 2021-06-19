using System;
using System.Collections.Generic;
using System.Text;
using Test.BusinessRule.Services.Email;
using Test.BusinessRule.Services.Membership;

namespace Test.BusinessRule.RuleType
{
    public class Membership : IRuleType
    {
        private readonly IMembershipService _membershipService;
        private readonly IEmailService _emailService;

        public Membership(IMembershipService membershipService,
            IEmailService emailService)
        {
            _membershipService = membershipService;
            _emailService = emailService;
        }

        public string RuleType => nameof(Membership);

        public void ApplyRule()
        {
            _membershipService.Activate();
            _emailService.Notify();
        }
    }
}
