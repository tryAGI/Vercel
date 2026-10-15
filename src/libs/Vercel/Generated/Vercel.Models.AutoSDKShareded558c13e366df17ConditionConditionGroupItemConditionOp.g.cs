
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp
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
    public static class AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShareded558c13e366df17ConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}