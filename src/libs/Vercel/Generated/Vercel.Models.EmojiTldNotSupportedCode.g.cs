
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum EmojiTldNotSupportedCode
    {
        /// <summary>
        ///
        /// </summary>
        EmojiTldNotSupported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmojiTldNotSupportedCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmojiTldNotSupportedCode value)
        {
            return value switch
            {
                EmojiTldNotSupportedCode.EmojiTldNotSupported => "emoji_tld_not_supported",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmojiTldNotSupportedCode? ToEnum(string value)
        {
            return value switch
            {
                "emoji_tld_not_supported" => EmojiTldNotSupportedCode.EmojiTldNotSupported,
                _ => null,
            };
        }
    }
}