
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp
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
    public static class GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Eq => "eq",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Ex => "ex",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Gt => "gt",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Gte => "gte",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Inc => "inc",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Lt => "lt",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Lte => "lte",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Neq => "neq",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Nex => "nex",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Ninc => "ninc",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Pre => "pre",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Re => "re",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Sub => "sub",
                GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Eq,
                "ex" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Ex,
                "gt" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Gt,
                "gte" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Gte,
                "inc" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Inc,
                "lt" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Lt,
                "lte" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Lte,
                "neq" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Neq,
                "nex" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Nex,
                "ninc" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Ninc,
                "pre" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Pre,
                "re" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Re,
                "sub" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Sub,
                "suf" => GetFirewallConfigResponseRuleVariant1ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}