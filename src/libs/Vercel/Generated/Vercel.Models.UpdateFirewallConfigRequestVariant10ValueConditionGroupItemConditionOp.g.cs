
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant10ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}