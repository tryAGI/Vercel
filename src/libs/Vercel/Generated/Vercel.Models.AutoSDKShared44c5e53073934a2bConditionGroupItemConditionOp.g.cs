
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp
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
    public static class AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.List => "list",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared44c5e53073934a2bConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}