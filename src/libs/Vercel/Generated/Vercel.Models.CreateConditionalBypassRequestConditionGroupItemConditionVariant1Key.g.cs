
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key
    {
        /// <summary>
        ///
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant1KeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key.UserAgent => "user-agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key? ToEnum(string value)
        {
            return value switch
            {
                "user-agent" => CreateConditionalBypassRequestConditionGroupItemConditionVariant1Key.UserAgent,
                _ => null,
            };
        }
    }
}