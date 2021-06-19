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

            var ruleType = new RuleFactory(ruleTypes).GetRuleType(nameof(PhysicalProduct));

            ruleType.ApplyRule();
        }
    }
}
