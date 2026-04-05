
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Inc,
                "lt" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant3ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}