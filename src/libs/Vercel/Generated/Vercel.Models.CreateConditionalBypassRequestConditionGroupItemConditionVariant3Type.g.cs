
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Header,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant3Type value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant3Type.Header => "header",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "header" => CreateConditionalBypassRequestConditionGroupItemConditionVariant3Type.Header,
                _ => null,
            };
        }
    }
}