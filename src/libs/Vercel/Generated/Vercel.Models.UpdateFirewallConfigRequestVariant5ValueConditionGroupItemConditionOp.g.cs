
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant5ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}