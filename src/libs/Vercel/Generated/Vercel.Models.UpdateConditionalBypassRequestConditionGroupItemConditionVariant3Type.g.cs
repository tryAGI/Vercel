
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Header,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConditionalBypassRequestConditionGroupItemConditionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Type value)
        {
            return value switch
            {
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Type.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "header" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant3Type.Header,
                _ => null,
            };
        }
    }
}