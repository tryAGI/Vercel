
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Generated value shape, must be `"url"`.
    /// </summary>
    public enum AutoSDKShared37c775f169729655BindingFormat
    {
        /// <summary>
        ///
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared37c775f169729655BindingFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared37c775f169729655BindingFormat value)
        {
            return value switch
            {
                AutoSDKShared37c775f169729655BindingFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared37c775f169729655BindingFormat? ToEnum(string value)
        {
            return value switch
            {
                "url" => AutoSDKShared37c775f169729655BindingFormat.Url,
                _ => null,
            };
        }
    }
}