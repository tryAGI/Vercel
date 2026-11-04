
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared82154186cc88506cHaVariant2Type
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
    public static class AutoSDKShared82154186cc88506cHaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared82154186cc88506cHaVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared82154186cc88506cHaVariant2Type.Cookie => "cookie",
                AutoSDKShared82154186cc88506cHaVariant2Type.Header => "header",
                AutoSDKShared82154186cc88506cHaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared82154186cc88506cHaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKShared82154186cc88506cHaVariant2Type.Cookie,
                "header" => AutoSDKShared82154186cc88506cHaVariant2Type.Header,
                "query" => AutoSDKShared82154186cc88506cHaVariant2Type.Query,
                _ => null,
            };
        }
    }
}