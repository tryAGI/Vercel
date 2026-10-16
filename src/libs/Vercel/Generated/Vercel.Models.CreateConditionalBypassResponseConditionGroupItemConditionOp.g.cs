
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassResponseConditionGroupItemConditionOp
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
    public static class CreateConditionalBypassResponseConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassResponseConditionGroupItemConditionOp value)
        {
            return value switch
            {
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Eq => "eq",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Ex => "ex",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Gt => "gt",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Gte => "gte",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Inc => "inc",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.List => "list",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Lt => "lt",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Lte => "lte",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Neq => "neq",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Nex => "nex",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Ninc => "ninc",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Pre => "pre",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Re => "re",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Sub => "sub",
                CreateConditionalBypassResponseConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassResponseConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Eq,
                "ex" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Ex,
                "gt" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Gt,
                "gte" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Gte,
                "inc" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Inc,
                "list" => CreateConditionalBypassResponseConditionGroupItemConditionOp.List,
                "lt" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Lt,
                "lte" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Lte,
                "neq" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Neq,
                "nex" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Nex,
                "ninc" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Ninc,
                "pre" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Pre,
                "re" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Re,
                "sub" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Sub,
                "suf" => CreateConditionalBypassResponseConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}