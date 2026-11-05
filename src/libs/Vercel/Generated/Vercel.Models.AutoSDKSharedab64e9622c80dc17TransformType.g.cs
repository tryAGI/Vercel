
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab64e9622c80dc17TransformType
    {
        /// <summary>
        ///
        /// </summary>
        RequestHeaders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedab64e9622c80dc17TransformTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab64e9622c80dc17TransformType value)
        {
            return value switch
            {
                AutoSDKSharedab64e9622c80dc17TransformType.RequestHeaders => "request.headers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab64e9622c80dc17TransformType? ToEnum(string value)
        {
            return value switch
            {
                "request.headers" => AutoSDKSharedab64e9622c80dc17TransformType.RequestHeaders,
                _ => null,
            };
        }
    }
}