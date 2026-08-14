
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp
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
    public static class UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Eq => "eq",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Ex => "ex",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Gt => "gt",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Gte => "gte",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Inc => "inc",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.List => "list",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Lt => "lt",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Lte => "lte",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Neq => "neq",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Nex => "nex",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Pre => "pre",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Re => "re",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Sub => "sub",
                UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Eq,
                "ex" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Ex,
                "gt" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Gt,
                "gte" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Gte,
                "inc" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Inc,
                "list" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.List,
                "lt" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Lt,
                "lte" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Lte,
                "neq" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Neq,
                "nex" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Pre,
                "re" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Re,
                "sub" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Sub,
                "suf" => UpdateFirewallConfigRequestVariant4ValueConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}