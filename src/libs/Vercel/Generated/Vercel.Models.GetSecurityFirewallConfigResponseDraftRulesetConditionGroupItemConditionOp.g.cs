
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseDraftRulesetConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}