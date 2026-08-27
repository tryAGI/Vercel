
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseCreatorVariant1ViaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseCreatorVariant1ViaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseCreatorVariant1ViaVariant1Type value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseCreatorVariant1ViaVariant1Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseCreatorVariant1ViaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => UpdateMicrofrontendsResponseCreatorVariant1ViaVariant1Type.App,
                _ => null,
            };
        }
    }
}