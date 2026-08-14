
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFirewallConfigResponseConditionConditionGroupItemConditionOp
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
    public static class GetFirewallConfigResponseConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFirewallConfigResponseConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Eq => "eq",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Ex => "ex",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Gt => "gt",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Gte => "gte",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Inc => "inc",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.List => "list",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Lt => "lt",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Lte => "lte",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Neq => "neq",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Nex => "nex",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Ninc => "ninc",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Pre => "pre",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Re => "re",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Sub => "sub",
                GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFirewallConfigResponseConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Eq,
                "ex" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Ex,
                "gt" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Gt,
                "gte" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Gte,
                "inc" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Inc,
                "list" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.List,
                "lt" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Lt,
                "lte" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Lte,
                "neq" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Neq,
                "nex" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Nex,
                "ninc" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Ninc,
                "pre" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Pre,
                "re" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Re,
                "sub" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Sub,
                "suf" => GetFirewallConfigResponseConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}