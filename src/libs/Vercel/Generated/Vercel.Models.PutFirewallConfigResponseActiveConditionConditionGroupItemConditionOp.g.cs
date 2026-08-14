
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp
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
    public static class PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Eq => "eq",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ex => "ex",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gt => "gt",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gte => "gte",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Inc => "inc",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.List => "list",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lt => "lt",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lte => "lte",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Neq => "neq",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Nex => "nex",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ninc => "ninc",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Pre => "pre",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Re => "re",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Sub => "sub",
                PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Eq,
                "ex" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ex,
                "gt" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gt,
                "gte" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Gte,
                "inc" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Inc,
                "list" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.List,
                "lt" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lt,
                "lte" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Lte,
                "neq" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Neq,
                "nex" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Nex,
                "ninc" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Ninc,
                "pre" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Pre,
                "re" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Re,
                "sub" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Sub,
                "suf" => PutFirewallConfigResponseActiveConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}