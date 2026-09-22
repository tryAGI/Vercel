
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared47a8daa582c3a982Kind
    {
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared47a8daa582c3a982KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared47a8daa582c3a982Kind value)
        {
            return value switch
            {
                AutoSDKShared47a8daa582c3a982Kind.Boolean => "boolean",
                AutoSDKShared47a8daa582c3a982Kind.Json => "json",
                AutoSDKShared47a8daa582c3a982Kind.Number => "number",
                AutoSDKShared47a8daa582c3a982Kind.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared47a8daa582c3a982Kind? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AutoSDKShared47a8daa582c3a982Kind.Boolean,
                "json" => AutoSDKShared47a8daa582c3a982Kind.Json,
                "number" => AutoSDKShared47a8daa582c3a982Kind.Number,
                "string" => AutoSDKShared47a8daa582c3a982Kind.String,
                _ => null,
            };
        }
    }
}