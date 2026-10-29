
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassResponseConditionGroupItemConditionOp
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
    public static class UpdateConditionalBypassResponseConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassResponseConditionGroupItemConditionOp value)
        {
            return value switch
            {
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Eq => "eq",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Ex => "ex",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Gt => "gt",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Gte => "gte",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Inc => "inc",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.List => "list",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Lt => "lt",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Lte => "lte",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Neq => "neq",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Nex => "nex",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Ninc => "ninc",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Pre => "pre",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Re => "re",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Sub => "sub",
                UpdateConditionalBypassResponseConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassResponseConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Eq,
                "ex" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Ex,
                "gt" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Gt,
                "gte" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Gte,
                "inc" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Inc,
                "list" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.List,
                "lt" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Lt,
                "lte" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Lte,
                "neq" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Neq,
                "nex" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Nex,
                "ninc" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Ninc,
                "pre" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Pre,
                "re" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Re,
                "sub" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Sub,
                "suf" => UpdateConditionalBypassResponseConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}