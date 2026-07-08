
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRulesetConditionGroupItemConditionOp
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
    public static class GetFirewallConfigResponseRulesetConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRulesetConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Eq => "eq",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Ex => "ex",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Gt => "gt",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Gte => "gte",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Inc => "inc",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.List => "list",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Lt => "lt",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Lte => "lte",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Neq => "neq",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Nex => "nex",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Ninc => "ninc",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Pre => "pre",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Re => "re",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Sub => "sub",
                GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRulesetConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Eq,
                "ex" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Ex,
                "gt" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Gt,
                "gte" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Gte,
                "inc" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Inc,
                "list" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.List,
                "lt" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Lt,
                "lte" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Lte,
                "neq" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Neq,
                "nex" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Nex,
                "ninc" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Ninc,
                "pre" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Pre,
                "re" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Re,
                "sub" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Sub,
                "suf" => GetFirewallConfigResponseRulesetConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}