
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKSharedb4706d78b2b82e72BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb4706d78b2b82e72BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb4706d78b2b82e72BindingFormat value)
        {
            return value switch
            {
                AutoSDKSharedb4706d78b2b82e72BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb4706d78b2b82e72BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKSharedb4706d78b2b82e72BindingFormat.Url,
                _ => null,
            };
        }
    }
}