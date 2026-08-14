
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant11ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}