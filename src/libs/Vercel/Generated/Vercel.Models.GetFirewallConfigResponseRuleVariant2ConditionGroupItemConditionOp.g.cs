
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp
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
    public static class GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Eq => "eq",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Ex => "ex",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Gt => "gt",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Gte => "gte",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Inc => "inc",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Lt => "lt",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Lte => "lte",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Neq => "neq",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Nex => "nex",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Ninc => "ninc",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Pre => "pre",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Re => "re",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Sub => "sub",
                GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Eq,
                "ex" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Ex,
                "gt" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Gt,
                "gte" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Gte,
                "inc" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Inc,
                "lt" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Lt,
                "lte" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Lte,
                "neq" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Neq,
                "nex" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Nex,
                "ninc" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Ninc,
                "pre" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Pre,
                "re" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Re,
                "sub" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Sub,
                "suf" => GetFirewallConfigResponseRuleVariant2ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}