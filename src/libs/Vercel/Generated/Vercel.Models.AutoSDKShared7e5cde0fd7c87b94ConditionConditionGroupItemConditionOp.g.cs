
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp
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
    public static class AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared7e5cde0fd7c87b94ConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}