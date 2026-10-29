
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op
    {
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        Pre,
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
    public static class UpdateConditionalBypassRequestConditionGroupItemConditionVariant3OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op value)
        {
            return value switch
            {
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Eq => "eq",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Pre => "pre",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Sub => "sub",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Eq,
                "pre" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Pre,
                "sub" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Sub,
                "suf" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Suf,
                _ => null,
            };
        }
    }
}