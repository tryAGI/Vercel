
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Path,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConditionalBypassRequestConditionGroupItemConditionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Type value)
        {
            return value switch
            {
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Type.Path => "path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "path" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant2Type.Path,
                _ => null,
            };
        }
    }
}