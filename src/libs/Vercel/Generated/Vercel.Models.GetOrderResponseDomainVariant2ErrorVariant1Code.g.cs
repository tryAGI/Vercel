
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant2ErrorVariant1Code
    {
        /// <summary>
        /// 
        /// </summary>
        UnsupportedLanguageCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant2ErrorVariant1CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant2ErrorVariant1Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant2ErrorVariant1Code.UnsupportedLanguageCode => "unsupported-language-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant2ErrorVariant1Code? ToEnum(string value)
        {
            return value switch
            {
                "unsupported-language-code" => GetOrderResponseDomainVariant2ErrorVariant1Code.UnsupportedLanguageCode,
                _ => null,
            };
        }
    }
}