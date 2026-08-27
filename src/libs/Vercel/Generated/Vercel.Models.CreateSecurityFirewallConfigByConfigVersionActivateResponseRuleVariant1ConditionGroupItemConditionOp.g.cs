
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Eq => "eq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Ex => "ex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Gt => "gt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Gte => "gte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Inc => "inc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.List => "list",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Lt => "lt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Lte => "lte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Neq => "neq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Nex => "nex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Ninc => "ninc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Pre => "pre",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Re => "re",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Sub => "sub",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Eq,
                "ex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Ex,
                "gt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Gt,
                "gte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Gte,
                "inc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Inc,
                "list" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.List,
                "lt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Lt,
                "lte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Lte,
                "neq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Neq,
                "nex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Nex,
                "ninc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Ninc,
                "pre" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Pre,
                "re" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Re,
                "sub" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Sub,
                "suf" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRuleVariant1ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}