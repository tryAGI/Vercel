
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp
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
    public static class AutoSDKShared037328971b8d11dbConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.List => "list",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared037328971b8d11dbConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}