
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant2ErrorVariant5Code
    {
        /// <summary>
        /// 
        /// </summary>
        ClaimsNoticeRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant2ErrorVariant5CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant2ErrorVariant5Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant2ErrorVariant5Code.ClaimsNoticeRequired => "claims-notice-required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant2ErrorVariant5Code? ToEnum(string value)
        {
            return value switch
            {
                "claims-notice-required" => GetOrderResponseDomainVariant2ErrorVariant5Code.ClaimsNoticeRequired,
                _ => null,
            };
        }
    }
}