
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared6ca7f4005d33343fBindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6ca7f4005d33343fBindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ca7f4005d33343fBindingFormat value)
        {
            return value switch
            {
                AutoSDKShared6ca7f4005d33343fBindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ca7f4005d33343fBindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared6ca7f4005d33343fBindingFormat.Url,
                _ => null,
            };
        }
    }
}