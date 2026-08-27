
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseDraftRuleVariant2ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}