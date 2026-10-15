
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassResponseResultConditionGroupItemConditionOp
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
    public static class CreateConditionalBypassResponseResultConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassResponseResultConditionGroupItemConditionOp value)
        {
            return value switch
            {
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Eq => "eq",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Ex => "ex",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Gt => "gt",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Gte => "gte",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Inc => "inc",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.List => "list",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Lt => "lt",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Lte => "lte",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Neq => "neq",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Nex => "nex",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Ninc => "ninc",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Pre => "pre",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Re => "re",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Sub => "sub",
                CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassResponseResultConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Eq,
                "ex" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Ex,
                "gt" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Gt,
                "gte" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Gte,
                "inc" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Inc,
                "list" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.List,
                "lt" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Lt,
                "lte" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Lte,
                "neq" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Neq,
                "nex" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Nex,
                "ninc" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Ninc,
                "pre" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Pre,
                "re" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Re,
                "sub" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Sub,
                "suf" => CreateConditionalBypassResponseResultConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}