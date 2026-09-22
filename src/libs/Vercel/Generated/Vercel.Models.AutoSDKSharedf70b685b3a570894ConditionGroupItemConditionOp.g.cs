
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp
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
    public static class AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.List => "list",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Re => "re",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.List,
                "lt" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKSharedf70b685b3a570894ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}