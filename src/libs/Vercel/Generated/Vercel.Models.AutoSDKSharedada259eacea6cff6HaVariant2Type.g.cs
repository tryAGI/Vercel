
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedada259eacea6cff6HaVariant2Type
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
    public static class AutoSDKSharedada259eacea6cff6HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedada259eacea6cff6HaVariant2Type value)
        {
            return value switch
            {
                AutoSDKSharedada259eacea6cff6HaVariant2Type.Cookie => "cookie",
                AutoSDKSharedada259eacea6cff6HaVariant2Type.Header => "header",
                AutoSDKSharedada259eacea6cff6HaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedada259eacea6cff6HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKSharedada259eacea6cff6HaVariant2Type.Cookie,
                "header" => AutoSDKSharedada259eacea6cff6HaVariant2Type.Header,
                "query" => AutoSDKSharedada259eacea6cff6HaVariant2Type.Query,
                _ => null,
            };
        }
    }
}