
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseDraftRuleVariant1ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}