
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared922c97954e29e8b6DaemonBindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared922c97954e29e8b6DaemonBindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared922c97954e29e8b6DaemonBindingFormat value)
        {
            return value switch
            {
                AutoSDKShared922c97954e29e8b6DaemonBindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared922c97954e29e8b6DaemonBindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared922c97954e29e8b6DaemonBindingFormat.Url,
                _ => null,
            };
        }
    }
}