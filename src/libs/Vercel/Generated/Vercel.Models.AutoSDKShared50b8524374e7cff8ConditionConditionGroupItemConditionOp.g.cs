
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp
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
    public static class AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared50b8524374e7cff8ConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}