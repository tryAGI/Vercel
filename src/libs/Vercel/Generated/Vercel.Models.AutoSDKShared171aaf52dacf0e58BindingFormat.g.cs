
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared171aaf52dacf0e58BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared171aaf52dacf0e58BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared171aaf52dacf0e58BindingFormat value)
        {
            return value switch
            {
                AutoSDKShared171aaf52dacf0e58BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared171aaf52dacf0e58BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared171aaf52dacf0e58BindingFormat.Url,
                _ => null,
            };
        }
    }
}