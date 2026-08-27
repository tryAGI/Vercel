
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant12ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}