
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared758f1bb5042637ceBindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared758f1bb5042637ceBindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared758f1bb5042637ceBindingFormat value)
        {
            return value switch
            {
                AutoSDKShared758f1bb5042637ceBindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared758f1bb5042637ceBindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared758f1bb5042637ceBindingFormat.Url,
                _ => null,
            };
        }
    }
}