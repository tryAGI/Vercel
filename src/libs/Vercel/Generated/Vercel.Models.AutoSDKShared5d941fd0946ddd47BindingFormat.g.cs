
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared5d941fd0946ddd47BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5d941fd0946ddd47BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5d941fd0946ddd47BindingFormat value)
        {
            return value switch
            {
                AutoSDKShared5d941fd0946ddd47BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5d941fd0946ddd47BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared5d941fd0946ddd47BindingFormat.Url,
                _ => null,
            };
        }
    }
}