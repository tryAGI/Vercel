
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}