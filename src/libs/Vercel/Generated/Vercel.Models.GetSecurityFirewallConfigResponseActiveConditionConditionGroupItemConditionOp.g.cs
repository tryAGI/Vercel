
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp
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
    public static class GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Eq => "eq",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ex => "ex",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gt => "gt",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gte => "gte",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Inc => "inc",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.List => "list",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lt => "lt",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lte => "lte",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Neq => "neq",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Nex => "nex",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ninc => "ninc",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Pre => "pre",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Re => "re",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Sub => "sub",
                GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Eq,
                "ex" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ex,
                "gt" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gt,
                "gte" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gte,
                "inc" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Inc,
                "list" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.List,
                "lt" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lt,
                "lte" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lte,
                "neq" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Neq,
                "nex" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Nex,
                "ninc" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ninc,
                "pre" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Pre,
                "re" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Re,
                "sub" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Sub,
                "suf" => GetSecurityFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}