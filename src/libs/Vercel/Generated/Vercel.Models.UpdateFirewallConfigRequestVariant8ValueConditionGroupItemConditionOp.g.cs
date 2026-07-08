
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant8ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}