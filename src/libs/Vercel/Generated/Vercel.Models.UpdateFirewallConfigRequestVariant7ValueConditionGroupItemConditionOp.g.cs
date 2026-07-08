
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant7ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}