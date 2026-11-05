
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17ResponseMissingItemType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseHeader,
        /// <summary>
        ///
        /// </summary>
        ResponseStatus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedab64e9622c80dc17ResponseMissingItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17ResponseMissingItemType value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17ResponseMissingItemType.ResponseHeader => "response_header",
                AutoSDKSharedab64e9622c80dc17ResponseMissingItemType.ResponseStatus => "response_status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17ResponseMissingItemType? ToEnum(string value)
        {
            return value switch
            {
                "response_header" => AutoSDKSharedab64e9622c80dc17ResponseMissingItemType.ResponseHeader,
                "response_status" => AutoSDKSharedab64e9622c80dc17ResponseMissingItemType.ResponseStatus,
                _ => null,
            };
        }
    }
}