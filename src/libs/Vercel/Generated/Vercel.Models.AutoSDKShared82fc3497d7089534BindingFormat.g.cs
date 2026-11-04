
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared82fc3497d7089534BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared82fc3497d7089534BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared82fc3497d7089534BindingFormat value)
        {
            return value switch
            {
                AutoSDKShared82fc3497d7089534BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared82fc3497d7089534BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared82fc3497d7089534BindingFormat.Url,
                _ => null,
            };
        }
    }
}