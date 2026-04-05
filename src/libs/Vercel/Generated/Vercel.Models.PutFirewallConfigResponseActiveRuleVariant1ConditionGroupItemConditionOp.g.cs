
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp
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
    public static class PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Eq => "eq",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ex => "ex",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gt => "gt",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gte => "gte",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Inc => "inc",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lt => "lt",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lte => "lte",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Neq => "neq",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Nex => "nex",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ninc => "ninc",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Pre => "pre",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Re => "re",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Sub => "sub",
                PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Eq,
                "ex" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ex,
                "gt" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gt,
                "gte" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Gte,
                "inc" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Inc,
                "lt" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lt,
                "lte" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Lte,
                "neq" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Neq,
                "nex" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Nex,
                "ninc" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Ninc,
                "pre" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Pre,
                "re" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Re,
                "sub" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Sub,
                "suf" => PutFirewallConfigResponseActiveRuleVariant1ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}