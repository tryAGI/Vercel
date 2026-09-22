
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfb6f42506e3e02aeVariant1Code
    {
        /// <summary>
        ///
        /// </summary>
        UnsupportedLanguageCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfb6f42506e3e02aeVariant1CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfb6f42506e3e02aeVariant1Code value)
        {
            return value switch
            {
                AutoSDKSharedfb6f42506e3e02aeVariant1Code.UnsupportedLanguageCode => "unsupported-language-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfb6f42506e3e02aeVariant1Code? ToEnum(string value)
        {
            return value switch
            {
                "unsupported-language-code" => AutoSDKSharedfb6f42506e3e02aeVariant1Code.UnsupportedLanguageCode,
                _ => null,
            };
        }
    }
}