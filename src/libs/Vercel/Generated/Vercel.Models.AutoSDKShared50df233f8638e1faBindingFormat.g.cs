
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared50df233f8638e1faBindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared50df233f8638e1faBindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared50df233f8638e1faBindingFormat value)
        {
            return value switch
            {
                AutoSDKShared50df233f8638e1faBindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared50df233f8638e1faBindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared50df233f8638e1faBindingFormat.Url,
                _ => null,
            };
        }
    }
}