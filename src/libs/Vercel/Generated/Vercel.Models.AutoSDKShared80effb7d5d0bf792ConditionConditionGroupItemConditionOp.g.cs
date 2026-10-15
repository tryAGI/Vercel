
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp
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
    public static class AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared80effb7d5d0bf792ConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}