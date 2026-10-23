
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared58ffef5c4d095b17Variant3Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared58ffef5c4d095b17Variant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared58ffef5c4d095b17Variant3Type value)
        {
            return value switch
            {
                AutoSDKShared58ffef5c4d095b17Variant3Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared58ffef5c4d095b17Variant3Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => AutoSDKShared58ffef5c4d095b17Variant3Type.App,
                _ => null,
            };
        }
    }
}