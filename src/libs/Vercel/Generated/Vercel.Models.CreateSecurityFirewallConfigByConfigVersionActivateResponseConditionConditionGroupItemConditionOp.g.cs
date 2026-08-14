
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp
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
    public static class CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Eq => "eq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Ex => "ex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Gt => "gt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Gte => "gte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Inc => "inc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.List => "list",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Lt => "lt",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Lte => "lte",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Neq => "neq",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Nex => "nex",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Ninc => "ninc",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Pre => "pre",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Re => "re",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Sub => "sub",
                CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Eq,
                "ex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Ex,
                "gt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Gt,
                "gte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Gte,
                "inc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Inc,
                "list" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.List,
                "lt" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Lt,
                "lte" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Lte,
                "neq" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Neq,
                "nex" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Nex,
                "ninc" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Ninc,
                "pre" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Pre,
                "re" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Re,
                "sub" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Sub,
                "suf" => CreateSecurityFirewallConfigByConfigVersionActivateResponseConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}