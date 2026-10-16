
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp
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
    public static class GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Eq => "eq",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Ex => "ex",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Gt => "gt",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Gte => "gte",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Inc => "inc",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.List => "list",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Lt => "lt",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Lte => "lte",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Neq => "neq",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Nex => "nex",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Ninc => "ninc",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Pre => "pre",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Re => "re",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Sub => "sub",
                GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Eq,
                "ex" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Ex,
                "gt" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Gt,
                "gte" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Gte,
                "inc" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Inc,
                "list" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.List,
                "lt" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Lt,
                "lte" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Lte,
                "neq" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Neq,
                "nex" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Nex,
                "ninc" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Ninc,
                "pre" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Pre,
                "re" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Re,
                "sub" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Sub,
                "suf" => GetConditionalBypassResponseVariant2RuleConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}