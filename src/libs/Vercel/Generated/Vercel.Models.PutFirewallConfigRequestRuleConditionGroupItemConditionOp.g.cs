
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigRequestRuleConditionGroupItemConditionOp
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
    public static class PutFirewallConfigRequestRuleConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRuleConditionGroupItemConditionOp value)
        {
            return value switch
            {
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Eq => "eq",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Ex => "ex",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Gt => "gt",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Gte => "gte",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Inc => "inc",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Lt => "lt",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Lte => "lte",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Neq => "neq",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Nex => "nex",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Ninc => "ninc",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Pre => "pre",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Re => "re",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Sub => "sub",
                PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRuleConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Eq,
                "ex" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Ex,
                "gt" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Gt,
                "gte" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Gte,
                "inc" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Inc,
                "lt" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Lt,
                "lte" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Lte,
                "neq" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Neq,
                "nex" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Nex,
                "ninc" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Ninc,
                "pre" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Pre,
                "re" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Re,
                "sub" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Sub,
                "suf" => PutFirewallConfigRequestRuleConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}