
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f73cd821829ef28HaVariant2Type
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
    public static class AutoSDKShared5f73cd821829ef28HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f73cd821829ef28HaVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared5f73cd821829ef28HaVariant2Type.Cookie => "cookie",
                AutoSDKShared5f73cd821829ef28HaVariant2Type.Header => "header",
                AutoSDKShared5f73cd821829ef28HaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f73cd821829ef28HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKShared5f73cd821829ef28HaVariant2Type.Cookie,
                "header" => AutoSDKShared5f73cd821829ef28HaVariant2Type.Header,
                "query" => AutoSDKShared5f73cd821829ef28HaVariant2Type.Query,
                _ => null,
            };
        }
    }
}