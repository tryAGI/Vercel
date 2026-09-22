
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp
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
    public static class AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.List => "list",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared08bf5d361fc08707ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}