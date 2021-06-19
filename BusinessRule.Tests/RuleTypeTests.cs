using System;
using Moq;
using Test.BusinessRule.RuleType;
using Test.BusinessRule.Services.PaymentService;
using Test.BusinessRule.Services.Shipping;
using Xunit;
using System.Linq;
using Test.BusinessRule.Services.Membership;
using Test.BusinessRule.Services.Email;

namespace BusinessRule.Tests
{
    public class RuleTypeTests
    {
        private readonly Mock<IShippingService> _mockShippingService;
        private readonly Mock<IPaymentService> _mockPaymentService;
        private readonly Mock<IMembershipService> _mockMembershipService;
        private readonly Mock<IEmailService> _mockEmailService;

        public RuleTypeTests()
        {
            _mockShippingService = new Mock<IShippingService>();
            _mockPaymentService = new Mock<IPaymentService>();
            _mockMembershipService = new Mock<IMembershipService>();
            _mockEmailService = new Mock<IEmailService>();
        }

        [Fact]
        public void RuleType_Should_Be_PhysicalProduct()
        {
            var product = new PhysicalProduct(_mockShippingService.Object, _mockPaymentService.Object);

            _mockShippingService.Setup(x => x.CreateSlip()).Returns(It.IsAny<bool>);
            _mockPaymentService.Setup(x => x.GenerateCommission()).Returns(It.IsAny<bool>);
            product.ApplyRule();

            Assert.Equal(nameof(PhysicalProduct), product.RuleType);
            //Assert.True()
        }

        [Fact]
        public void RuleType_Should_Be_Book()
        {
            var product = new Book(_mockShippingService.Object, _mockPaymentService.Object);

            _mockShippingService.Setup(x => x.CreateDuplicateSlip()).Returns(It.IsAny<bool>);
            _mockPaymentService.Setup(x => x.GenerateCommission()).Returns(It.IsAny<bool>);

            Assert.Equal(nameof(Book), product.RuleType);
        }

        [Fact]
        public void RuleType_Should_Be_Membership()
        {
            var product = new Membership(null, _mockEmailService.Object);

            _mockMembershipService.Setup(x => x.Activate()).Returns(It.IsAny<bool>);
            _mockEmailService.Setup(x => x.Notify());

            Assert.Equal(nameof(Membership), product.RuleType);
        }

        [Fact]
        public void RuleType_Should_Be_UpgradeMembership()
        {
            var product = new UpgradeMembership(_mockMembershipService.Object, _mockEmailService.Object);

            _mockMembershipService.Setup(x => x.Upgrade()).Returns(It.IsAny<bool>);
            _mockEmailService.Setup(x => x.Notify());

            Assert.Equal(nameof(UpgradeMembership), product.RuleType);
        }

        [Fact]
        public void RuleType_Should_Be_Video()
        {
            var product = new Video(_mockShippingService.Object);

            _mockShippingService.Setup(x => x.CreateSlipWithVideo(It.IsAny<object>())).Returns(It.IsAny<bool>);
            Assert.Equal(nameof(Video), product.RuleType);
        }
    }
}
