
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op
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
    public static class UpdateConditionalBypassRequestConditionGroupItemConditionVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op value)
        {
            return value switch
            {
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Eq => "eq",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Pre => "pre",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Sub => "sub",
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "eq" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Eq,
                "pre" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Pre,
                "sub" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Sub,
                "suf" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Suf,
                _ => null,
            };
        }
    }
}