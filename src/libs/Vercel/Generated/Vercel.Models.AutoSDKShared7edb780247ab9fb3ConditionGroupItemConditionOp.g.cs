
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp
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
    public static class AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.List => "list",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared7edb780247ab9fb3ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}