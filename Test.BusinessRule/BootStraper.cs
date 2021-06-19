using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Test.BusinessRule.RuleType;
using Test.BusinessRule.Services.Email;
using Test.BusinessRule.Services.Membership;
using Test.BusinessRule.Services.PaymentService;
using Test.BusinessRule.Services.Shipping;

namespace Test.BusinessRule
{
    public class BootStraper
    {
        public static IServiceProvider Init()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IRuleType, PhysicalProduct>();
            serviceCollection.AddScoped<IRuleType, Book>();
            serviceCollection.AddScoped<IRuleType, Membership>();
            serviceCollection.AddScoped<IRuleType, UpgradeMembership>();
            serviceCollection.AddScoped<IRuleType, Video>();

            serviceCollection.AddScoped<IShippingService, ShippingService>();
            serviceCollection.AddScoped<IPaymentService, PaymentService>();
            serviceCollection.AddScoped<IEmailService, EmailService>();
            serviceCollection.AddScoped<IMembershipService, MembershipService>();

            return serviceCollection.BuildServiceProvider();
        }

    }
}
