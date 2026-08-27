
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseVersionRulesetConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}