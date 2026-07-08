
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp
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
    public static class PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Eq => "eq",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ex => "ex",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gt => "gt",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gte => "gte",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Inc => "inc",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.List => "list",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lt => "lt",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lte => "lte",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Neq => "neq",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Nex => "nex",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ninc => "ninc",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Pre => "pre",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Re => "re",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Sub => "sub",
                PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Eq,
                "ex" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ex,
                "gt" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gt,
                "gte" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Gte,
                "inc" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Inc,
                "list" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.List,
                "lt" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lt,
                "lte" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Lte,
                "neq" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Neq,
                "nex" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Nex,
                "ninc" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Ninc,
                "pre" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Pre,
                "re" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Re,
                "sub" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Sub,
                "suf" => PutFirewallConfigResponseActiveRulesetConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}