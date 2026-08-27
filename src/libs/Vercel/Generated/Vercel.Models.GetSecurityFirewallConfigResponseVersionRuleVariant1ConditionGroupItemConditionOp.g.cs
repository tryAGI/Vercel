
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseVersionRuleVariant1ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}