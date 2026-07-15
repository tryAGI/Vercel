
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Eq => "eq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Ex => "ex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Gt => "gt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Gte => "gte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Inc => "inc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.List => "list",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Lt => "lt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Lte => "lte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Neq => "neq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Nex => "nex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Ninc => "ninc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Pre => "pre",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Re => "re",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Sub => "sub",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Eq,
                "ex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Ex,
                "gt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Gt,
                "gte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Gte,
                "inc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Inc,
                "list" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.List,
                "lt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Lt,
                "lte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Lte,
                "neq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Neq,
                "nex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Nex,
                "ninc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Ninc,
                "pre" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Pre,
                "re" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Re,
                "sub" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Sub,
                "suf" => CreateSecurityFirewallConfigByConfigVersionActivateResponseRulesetConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}