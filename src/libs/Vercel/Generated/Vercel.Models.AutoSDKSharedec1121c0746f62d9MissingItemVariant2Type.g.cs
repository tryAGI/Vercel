
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type
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
    public static class AutoSDKSharedec1121c0746f62d9MissingItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type value)
        {
            return value switch
            {
                AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type.Cookie => "cookie",
                AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type.Header => "header",
                AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type.Cookie,
                "header" => AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type.Header,
                "query" => AutoSDKSharedec1121c0746f62d9MissingItemVariant2Type.Query,
                _ => null,
            };
        }
    }
}