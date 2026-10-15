
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp
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
    public static class GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Eq => "eq",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Ex => "ex",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Gt => "gt",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Gte => "gte",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Inc => "inc",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.List => "list",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Lt => "lt",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Lte => "lte",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Neq => "neq",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Nex => "nex",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Ninc => "ninc",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Pre => "pre",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Re => "re",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Sub => "sub",
                GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Eq,
                "ex" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Ex,
                "gt" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Gt,
                "gte" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Gte,
                "inc" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Inc,
                "list" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.List,
                "lt" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Lt,
                "lte" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Lte,
                "neq" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Neq,
                "nex" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Nex,
                "ninc" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Ninc,
                "pre" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Pre,
                "re" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Re,
                "sub" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Sub,
                "suf" => GetConditionalBypassResponseVariant2ResultItemConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}