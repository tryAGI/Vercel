
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Key
    {
        /// <summary>
        ///
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConditionalBypassRequestConditionGroupItemConditionVariant1KeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Key value)
        {
            return value switch
            {
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Key.UserAgent => "user-agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Key? ToEnum(string value)
        {
            return value switch
            {
                "user-agent" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant1Key.UserAgent,
                _ => null,
            };
        }
    }
}