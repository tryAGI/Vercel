
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp
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
    public static class AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared1ed2975831fbb888ConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}