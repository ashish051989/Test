using System;
using System.Collections.Generic;
using System.Text;

namespace Test.BusinessRule.RuleType
{
    public interface IRuleType
    {
        string RuleType { get; }
        void ApplyRule();
    }
}
