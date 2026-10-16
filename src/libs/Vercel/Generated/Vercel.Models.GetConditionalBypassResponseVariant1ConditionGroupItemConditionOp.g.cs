
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp
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
    public static class GetConditionalBypassResponseVariant1ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Eq => "eq",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Ex => "ex",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Gt => "gt",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Gte => "gte",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Inc => "inc",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.List => "list",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Lt => "lt",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Lte => "lte",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Neq => "neq",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Nex => "nex",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Ninc => "ninc",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Pre => "pre",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Re => "re",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Sub => "sub",
                GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Eq,
                "ex" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Ex,
                "gt" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Gt,
                "gte" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Gte,
                "inc" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Inc,
                "list" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.List,
                "lt" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Lt,
                "lte" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Lte,
                "neq" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Neq,
                "nex" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Nex,
                "ninc" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Ninc,
                "pre" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Pre,
                "re" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Re,
                "sub" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Sub,
                "suf" => GetConditionalBypassResponseVariant1ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}