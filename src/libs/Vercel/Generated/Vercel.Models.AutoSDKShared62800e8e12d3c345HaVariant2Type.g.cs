
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared62800e8e12d3c345HaVariant2Type
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
    public static class AutoSDKShared62800e8e12d3c345HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared62800e8e12d3c345HaVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared62800e8e12d3c345HaVariant2Type.Cookie => "cookie",
                AutoSDKShared62800e8e12d3c345HaVariant2Type.Header => "header",
                AutoSDKShared62800e8e12d3c345HaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared62800e8e12d3c345HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKShared62800e8e12d3c345HaVariant2Type.Cookie,
                "header" => AutoSDKShared62800e8e12d3c345HaVariant2Type.Header,
                "query" => AutoSDKShared62800e8e12d3c345HaVariant2Type.Query,
                _ => null,
            };
        }
    }
}