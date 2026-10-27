
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKSharedb7e537bead367337BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedb7e537bead367337BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb7e537bead367337BindingFormat value)
        {
            return value switch
            {
                AutoSDKSharedb7e537bead367337BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb7e537bead367337BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKSharedb7e537bead367337BindingFormat.Url,
                _ => null,
            };
        }
    }
}