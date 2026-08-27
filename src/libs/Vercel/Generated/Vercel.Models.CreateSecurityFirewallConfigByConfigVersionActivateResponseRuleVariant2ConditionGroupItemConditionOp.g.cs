
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Eq => "eq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Ex => "ex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Gt => "gt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Gte => "gte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Inc => "inc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.List => "list",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Lt => "lt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Lte => "lte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Neq => "neq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Nex => "nex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Ninc => "ninc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Pre => "pre",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Re => "re",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Sub => "sub",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Eq,
                "ex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Ex,
                "gt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Gt,
                "gte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Gte,
                "inc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Inc,
                "list" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.List,
                "lt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Lt,
                "lte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Lte,
                "neq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Neq,
                "nex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Nex,
                "ninc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Ninc,
                "pre" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Pre,
                "re" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Re,
                "sub" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Sub,
                "suf" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant2ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}