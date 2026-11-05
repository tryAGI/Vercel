
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp
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
    public static class AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.List => "list",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Re => "re",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.List,
                "lt" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKSharedb38a5d43be350768ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}