
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConditionalBypassResponseVariant1ResultItemConditionOp
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
    public static class GetConditionalBypassResponseVariant1ResultItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConditionalBypassResponseVariant1ResultItemConditionOp value)
        {
            return value switch
            {
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Eq => "eq",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Ex => "ex",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Gt => "gt",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Gte => "gte",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Inc => "inc",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.List => "list",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Lt => "lt",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Lte => "lte",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Neq => "neq",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Nex => "nex",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Ninc => "ninc",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Pre => "pre",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Re => "re",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Sub => "sub",
                GetConditionalBypassResponseVariant1ResultItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConditionalBypassResponseVariant1ResultItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Eq,
                "ex" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Ex,
                "gt" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Gt,
                "gte" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Gte,
                "inc" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Inc,
                "list" => GetConditionalBypassResponseVariant1ResultItemConditionOp.List,
                "lt" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Lt,
                "lte" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Lte,
                "neq" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Neq,
                "nex" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Nex,
                "ninc" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Ninc,
                "pre" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Pre,
                "re" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Re,
                "sub" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Sub,
                "suf" => GetConditionalBypassResponseVariant1ResultItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}