
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp
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
    public static class AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.List => "list",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared17a9bc9c3c063edbConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}