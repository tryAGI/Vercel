
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseVersionRuleVariant2ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}