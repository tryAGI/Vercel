
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The grant type, when using x-www-form-urlencoded content type
    /// </summary>
    public enum ExchangeSsoTokenRequestVariant2GrantType
    {
        /// <summary>
        /// 
        /// </summary>
        RefreshToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExchangeSsoTokenRequestVariant2GrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExchangeSsoTokenRequestVariant2GrantType value)
        {
            return value switch
            {
                ExchangeSsoTokenRequestVariant2GrantType.RefreshToken => "refresh_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExchangeSsoTokenRequestVariant2GrantType? ToEnum(string value)
        {
            return value switch
            {
                "refresh_token" => ExchangeSsoTokenRequestVariant2GrantType.RefreshToken,
                _ => null,
            };
        }
    }
}