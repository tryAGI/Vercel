
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKSharedec20b3976551b9ebBindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedec20b3976551b9ebBindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedec20b3976551b9ebBindingFormat value)
        {
            return value switch
            {
                AutoSDKSharedec20b3976551b9ebBindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedec20b3976551b9ebBindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKSharedec20b3976551b9ebBindingFormat.Url,
                _ => null,
            };
        }
    }
}