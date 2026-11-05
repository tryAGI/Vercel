
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp
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
    public static class AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKSharedb4cb9cbf2561e851ConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}