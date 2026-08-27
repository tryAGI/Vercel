
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant6ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}