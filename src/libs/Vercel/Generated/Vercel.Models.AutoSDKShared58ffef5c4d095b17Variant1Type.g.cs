
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared58ffef5c4d095b17Variant1Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared58ffef5c4d095b17Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared58ffef5c4d095b17Variant1Type value)
        {
            return value switch
            {
                AutoSDKShared58ffef5c4d095b17Variant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared58ffef5c4d095b17Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => AutoSDKShared58ffef5c4d095b17Variant1Type.User,
                _ => null,
            };
        }
    }
}