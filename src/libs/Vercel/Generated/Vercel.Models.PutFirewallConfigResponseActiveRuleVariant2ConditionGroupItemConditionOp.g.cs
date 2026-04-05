
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp
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
    public static class PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Eq => "eq",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ex => "ex",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gt => "gt",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gte => "gte",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Inc => "inc",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lt => "lt",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lte => "lte",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Neq => "neq",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Nex => "nex",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ninc => "ninc",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Pre => "pre",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Re => "re",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Sub => "sub",
                PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Eq,
                "ex" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ex,
                "gt" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gt,
                "gte" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Gte,
                "inc" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Inc,
                "lt" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lt,
                "lte" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Lte,
                "neq" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Neq,
                "nex" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Nex,
                "ninc" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Ninc,
                "pre" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Pre,
                "re" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Re,
                "sub" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Sub,
                "suf" => PutFirewallConfigResponseActiveRuleVariant2ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}