
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared58ffef5c4d095b17Variant5Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared58ffef5c4d095b17Variant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared58ffef5c4d095b17Variant5Type value)
        {
            return value switch
            {
                AutoSDKShared58ffef5c4d095b17Variant5Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared58ffef5c4d095b17Variant5Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => AutoSDKShared58ffef5c4d095b17Variant5Type.System,
                _ => null,
            };
        }
    }
}