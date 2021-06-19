using System;
using Microsoft.Extensions.DependencyInjection;
using Test.BusinessRule.RuleType;

namespace Test.BusinessRule
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = BootStraper.Init();

            var ruleTypes = provider.GetServices<IRuleType>();

            Console.WriteLine($"Please Enter Product Type : {nameof(PhysicalProduct)}, " +
                $"{nameof(Book)}, {nameof(Membership)}, {nameof(UpgradeMembership)}, {nameof(Video)}");

            var productType = Console.ReadLine();

            if (string.IsNullOrEmpty(productType))
                Console.WriteLine("Please Enter the Product Type");

            var ruleType = new RuleFactory(ruleTypes).GetRuleType(productType);

            ruleType.ApplyRule();
        }
    }
}
