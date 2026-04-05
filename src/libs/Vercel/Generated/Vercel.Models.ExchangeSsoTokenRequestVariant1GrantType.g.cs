
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The grant type, when using x-www-form-urlencoded content type
    /// </summary>
    public enum ExchangeSsoTokenRequestVariant1GrantType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExchangeSsoTokenRequestVariant1GrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExchangeSsoTokenRequestVariant1GrantType value)
        {
            return value switch
            {
                ExchangeSsoTokenRequestVariant1GrantType.AuthorizationCode => "authorization_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExchangeSsoTokenRequestVariant1GrantType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_code" => ExchangeSsoTokenRequestVariant1GrantType.AuthorizationCode,
                _ => null,
            };
        }
    }
}