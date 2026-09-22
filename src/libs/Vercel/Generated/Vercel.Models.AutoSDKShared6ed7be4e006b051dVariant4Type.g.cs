
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed7be4e006b051dVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ed7be4e006b051dVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed7be4e006b051dVariant4Type value)
        {
            return value switch
            {
                AutoSDKShared6ed7be4e006b051dVariant4Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed7be4e006b051dVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => AutoSDKShared6ed7be4e006b051dVariant4Type.Vercel,
                _ => null,
            };
        }
    }
}