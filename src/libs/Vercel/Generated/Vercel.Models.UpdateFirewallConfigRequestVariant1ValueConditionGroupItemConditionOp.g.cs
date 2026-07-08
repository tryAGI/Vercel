
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant1ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}