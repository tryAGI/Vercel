
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed7be4e006b051dVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ed7be4e006b051dVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed7be4e006b051dVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared6ed7be4e006b051dVariant2Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed7be4e006b051dVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => AutoSDKShared6ed7be4e006b051dVariant2Type.Github,
                _ => null,
            };
        }
    }
}