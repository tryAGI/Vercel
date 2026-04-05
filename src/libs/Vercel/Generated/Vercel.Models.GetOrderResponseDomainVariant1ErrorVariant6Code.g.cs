
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant1ErrorVariant6Code
    {
        /// <summary>
        /// 
        /// </summary>
        CannotTransferInUntil,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant1ErrorVariant6CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant1ErrorVariant6Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant1ErrorVariant6Code.CannotTransferInUntil => "cannot-transfer-in-until",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant1ErrorVariant6Code? ToEnum(string value)
        {
            return value switch
            {
                "cannot-transfer-in-until" => GetOrderResponseDomainVariant1ErrorVariant6Code.CannotTransferInUntil,
                _ => null,
            };
        }
    }
}