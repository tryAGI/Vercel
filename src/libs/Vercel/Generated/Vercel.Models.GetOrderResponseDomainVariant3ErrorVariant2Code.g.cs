
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant2Code
    {
        /// <summary>
        /// 
        /// </summary>
        IncorrectLanguageCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3ErrorVariant2CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant2Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant2Code.IncorrectLanguageCode => "incorrect-language-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant2Code? ToEnum(string value)
        {
            return value switch
            {
                "incorrect-language-code" => GetOrderResponseDomainVariant3ErrorVariant2Code.IncorrectLanguageCode,
                _ => null,
            };
        }
    }
}