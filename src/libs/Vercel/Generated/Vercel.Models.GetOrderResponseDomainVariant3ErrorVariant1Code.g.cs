
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant1Code
    {
        /// <summary>
        /// 
        /// </summary>
        UnsupportedLanguageCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3ErrorVariant1CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant1Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant1Code.UnsupportedLanguageCode => "unsupported-language-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant1Code? ToEnum(string value)
        {
            return value switch
            {
                "unsupported-language-code" => GetOrderResponseDomainVariant3ErrorVariant1Code.UnsupportedLanguageCode,
                _ => null,
            };
        }
    }
}