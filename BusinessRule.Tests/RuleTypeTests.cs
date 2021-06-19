using System;
using Moq;
using Test.BusinessRule.RuleType;
using Test.BusinessRule.Services.PaymentService;
using Test.BusinessRule.Services.Shipping;
using Xunit;
using System.Linq;

namespace BusinessRule.Tests
{
    public class RuleTypeTests
    {
        private readonly Mock<IShippingService> _mockShippingService;
        private readonly Mock<PaymentService> _mockPaymentService;

        public RuleTypeTests()
        {
            _mockShippingService = new Mock<IShippingService>();
            _mockPaymentService = new Mock<PaymentService>();
        }

        [Fact]
        public void RuleType_Should_Be_PhysicalProduct()
        {
            var product = new PhysicalProduct(_mockShippingService.Object, _mockPaymentService.Object);

            _mockShippingService.Setup(x => x.CreateSlip());
            product.ApplyRule();

            Assert.Equal(nameof(PhysicalProduct), product.RuleType);
            //Assert.True()
        }

        [Fact]
        public void RuleType_Should_Be_Book()
        {
            var product = new Book(_mockShippingService.Object, _mockPaymentService.Object);

            _mockShippingService.Setup(x => x.CreateDuplicateSlip());
            product.ApplyRule();

            Assert.Equal(nameof(Book), product.RuleType);
        }
    }
}
