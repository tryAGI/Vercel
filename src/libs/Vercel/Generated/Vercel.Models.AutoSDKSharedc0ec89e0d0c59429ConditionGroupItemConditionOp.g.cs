
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp
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
    public static class AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.List => "list",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Re => "re",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.List,
                "lt" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKSharedc0ec89e0d0c59429ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}