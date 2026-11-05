
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp
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
    public static class AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.List => "list",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Re => "re",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.List,
                "lt" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKSharede10df3c22a339c10ConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}