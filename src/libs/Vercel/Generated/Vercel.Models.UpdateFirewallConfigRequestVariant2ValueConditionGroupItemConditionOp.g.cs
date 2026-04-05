
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Inc,
                "lt" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant2ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}