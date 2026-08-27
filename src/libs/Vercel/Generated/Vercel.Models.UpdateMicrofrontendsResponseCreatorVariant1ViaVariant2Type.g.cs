
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseCreatorVariant1ViaVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseCreatorVariant1ViaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseCreatorVariant1ViaVariant2Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseCreatorVariant1ViaVariant2Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseCreatorVariant1ViaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => UpdateMicrofrontendsResponseCreatorVariant1ViaVariant2Type.Integration,
                _ => null,
            };
        }
    }
}