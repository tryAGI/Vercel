
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum PutFirewallConfigRequestRulesetConditionGroupItemConditionOp
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
    public static class PutFirewallConfigRequestRulesetConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutFirewallConfigRequestRulesetConditionGroupItemConditionOp value)
        {
            return value switch
            {
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Eq => "eq",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Ex => "ex",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Gt => "gt",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Gte => "gte",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Inc => "inc",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.List => "list",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Lt => "lt",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Lte => "lte",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Neq => "neq",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Nex => "nex",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Ninc => "ninc",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Pre => "pre",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Re => "re",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Sub => "sub",
                PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutFirewallConfigRequestRulesetConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Eq,
                "ex" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Ex,
                "gt" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Gt,
                "gte" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Gte,
                "inc" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Inc,
                "list" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.List,
                "lt" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Lt,
                "lte" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Lte,
                "neq" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Neq,
                "nex" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Nex,
                "ninc" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Ninc,
                "pre" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Pre,
                "re" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Re,
                "sub" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Sub,
                "suf" => PutFirewallConfigRequestRulesetConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}