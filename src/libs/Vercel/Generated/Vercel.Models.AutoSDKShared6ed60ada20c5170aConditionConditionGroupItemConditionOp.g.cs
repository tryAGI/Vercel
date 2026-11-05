
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp
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
    public static class AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared6ed60ada20c5170aConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}