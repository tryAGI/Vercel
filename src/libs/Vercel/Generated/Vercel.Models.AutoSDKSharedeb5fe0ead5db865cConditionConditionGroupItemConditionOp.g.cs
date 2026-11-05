
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp
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
    public static class AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKSharedeb5fe0ead5db865cConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}