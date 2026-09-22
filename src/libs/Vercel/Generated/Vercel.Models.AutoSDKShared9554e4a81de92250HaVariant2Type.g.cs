
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9554e4a81de92250HaVariant2Type
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
    public static class AutoSDKShared9554e4a81de92250HaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9554e4a81de92250HaVariant2Type value)
        {
            return value switch
            {
                AutoSDKShared9554e4a81de92250HaVariant2Type.Cookie => "cookie",
                AutoSDKShared9554e4a81de92250HaVariant2Type.Header => "header",
                AutoSDKShared9554e4a81de92250HaVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9554e4a81de92250HaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKShared9554e4a81de92250HaVariant2Type.Cookie,
                "header" => AutoSDKShared9554e4a81de92250HaVariant2Type.Header,
                "query" => AutoSDKShared9554e4a81de92250HaVariant2Type.Query,
                _ => null,
            };
        }
    }
}