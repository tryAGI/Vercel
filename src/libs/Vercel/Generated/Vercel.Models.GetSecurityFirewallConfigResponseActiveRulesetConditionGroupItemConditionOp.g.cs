
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Ex,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Inc,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        Nex,
        /// <summary>
        /// 
        /// </summary>
        Ninc,
        /// <summary>
        /// 
        /// </summary>
        Pre,
        /// <summary>
        /// 
        /// </summary>
        Re,
        /// <summary>
        /// 
        /// </summary>
        Sub,
        /// <summary>
        /// 
        /// </summary>
        Suf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}