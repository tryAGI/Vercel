
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        UserAgent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant1Type value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant1Type.UserAgent => "user_agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user_agent" => CreateConditionalBypassRequestConditionGroupItemConditionVariant1Type.UserAgent,
                _ => null,
            };
        }
    }
}