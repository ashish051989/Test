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
