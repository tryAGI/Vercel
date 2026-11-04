
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared947f69fa305d000eMissingItemVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Cookie,
        /// <summary>
        ///
        /// </summary>
        Header,
        /// <summary>
        ///
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared947f69fa305d000eMissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared947f69fa305d000eMissingItemVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared947f69fa305d000eMissingItemVariant2Type.Cookie => "cookie",
                AutoSDKShared947f69fa305d000eMissingItemVariant2Type.Header => "header",
                AutoSDKShared947f69fa305d000eMissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared947f69fa305d000eMissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKShared947f69fa305d000eMissingItemVariant2Type.Cookie,
                "header" => AutoSDKShared947f69fa305d000eMissingItemVariant2Type.Header,
                "query" => AutoSDKShared947f69fa305d000eMissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}