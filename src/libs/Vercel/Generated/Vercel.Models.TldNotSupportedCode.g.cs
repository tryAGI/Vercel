
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TldNotSupportedCode
    {
        /// <summary>
        /// 
        /// </summary>
        TldNotSupported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TldNotSupportedCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TldNotSupportedCode value)
        {
            return value switch
            {
                TldNotSupportedCode.TldNotSupported => "tld_not_supported",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TldNotSupportedCode? ToEnum(string value)
        {
            return value switch
            {
                "tld_not_supported" => TldNotSupportedCode.TldNotSupported,
                _ => null,
            };
        }
    }
}