using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.BusinessRule.RuleType
{
    public class RuleFactory
    {
        public IEnumerable<IRuleType> _ruleTypes;

        public RuleFactory(IEnumerable<IRuleType> ruleTypes)
        {
            _ruleTypes = ruleTypes;
        }
        
        public IRuleType GetRuleType(string ruleType)
        {
            return _ruleTypes.FirstOrDefault(x => x.RuleType == ruleType);
        }
        
    }
}
