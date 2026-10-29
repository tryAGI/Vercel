
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op
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
    public static class UpdateConditionalBypassRequestConditionGroupItemConditionVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op value)
        {
            return value switch
            {
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Eq => "eq",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Pre => "pre",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Sub => "sub",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Eq,
                "pre" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Pre,
                "sub" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Sub,
                "suf" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Suf,
                _ => null,
            };
        }
    }
}