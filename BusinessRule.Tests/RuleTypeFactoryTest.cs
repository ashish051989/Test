using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Test.BusinessRule.RuleType;
using Test.BusinessRule.Services.Email;
using Test.BusinessRule.Services.Membership;
using Test.BusinessRule.Services.PaymentService;
using Test.BusinessRule.Services.Shipping;
using Xunit;

namespace BusinessRule.Tests
{
    public class RuleTypeFactoryTest
    {
        private readonly IEnumerable<IRuleType> ruleTypes;

        private readonly Mock<IShippingService> _mockShippingService;
        private readonly Mock<IPaymentService> _mockPaymentService;
        private readonly Mock<IMembershipService> _mockMembershipService;
        private readonly Mock<IEmailService> _mockEmailService;

        public RuleTypeFactoryTest()
        {
            _mockShippingService = new Mock<IShippingService>();
            _mockPaymentService = new Mock<IPaymentService>();
            _mockMembershipService = new Mock<IMembershipService>();
            _mockEmailService = new Mock<IEmailService>();

            ruleTypes = new List<IRuleType>
            {
                new PhysicalProduct(_mockShippingService.Object, _mockPaymentService.Object),
                new Book(_mockShippingService.Object, _mockPaymentService.Object),
                new Membership(_mockMembershipService.Object, _mockEmailService.Object),
                new UpgradeMembership(_mockMembershipService.Object,_mockEmailService.Object),
                new Video(_mockShippingService.Object)
            };
        }

        [Fact]
        public void RuleType_Should_Be_For_PhysicalProduct()
        {
            var ruleType = new RuleFactory(ruleTypes).GetRuleType(nameof(PhysicalProduct));

            Assert.IsType<PhysicalProduct>(ruleType);
        }

        [Fact]
        public void RuleType_Should_Be_For_Book()
        {
            var ruleType = new RuleFactory(ruleTypes).GetRuleType(nameof(Book));

            Assert.IsType<Book>(ruleType);
        }

        [Fact]
        public void RuleType_Should_Be_For_Membership()
        {
            var ruleType = new RuleFactory(ruleTypes).GetRuleType(nameof(Membership));

            Assert.IsType<Membership>(ruleType);
        }

        [Fact]
        public void RuleType_Should_Be_For_UpgradeMembership()
        {
            var ruleType = new RuleFactory(ruleTypes).GetRuleType(nameof(UpgradeMembership));

            Assert.IsType<UpgradeMembership>(ruleType);
        }

        [Fact]
        public void RuleType_Should_Be_For_Video()
        {
            var ruleType = new RuleFactory(ruleTypes).GetRuleType(nameof(Video));

            Assert.IsType<Video>(ruleType);
        }
    }
}
