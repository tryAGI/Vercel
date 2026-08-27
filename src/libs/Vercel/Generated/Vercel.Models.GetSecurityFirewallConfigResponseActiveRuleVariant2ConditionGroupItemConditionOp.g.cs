
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}