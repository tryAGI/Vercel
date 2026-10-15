
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Path,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant2Type value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant2Type.Path => "path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "path" => CreateConditionalBypassRequestConditionGroupItemConditionVariant2Type.Path,
                _ => null,
            };
        }
    }
}