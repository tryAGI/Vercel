
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp
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
    public static class AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp value)
        {
            return value switch
            {
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Eq => "eq",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Ex => "ex",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Gt => "gt",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Gte => "gte",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Inc => "inc",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.List => "list",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Lt => "lt",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Lte => "lte",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Neq => "neq",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Nex => "nex",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Ninc => "ninc",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Pre => "pre",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Re => "re",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Sub => "sub",
                AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Eq,
                "ex" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Ex,
                "gt" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Gt,
                "gte" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Gte,
                "inc" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Inc,
                "list" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.List,
                "lt" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Lt,
                "lte" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Lte,
                "neq" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Neq,
                "nex" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Nex,
                "ninc" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Ninc,
                "pre" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Pre,
                "re" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Re,
                "sub" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Sub,
                "suf" => AutoSDKShared1629dac811485089ConditionConditionGroupItemConditionOp.Suf,
                _ => null,
            };
        }
    }
}