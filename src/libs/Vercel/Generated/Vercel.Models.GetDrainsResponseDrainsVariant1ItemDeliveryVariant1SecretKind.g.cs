
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemDeliveryVariant1SecretKind
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainsResponseDrainsVariant1ItemDeliveryVariant1SecretKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemDeliveryVariant1SecretKind value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemDeliveryVariant1SecretKind.IntegrationSecret => "INTEGRATION_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemDeliveryVariant1SecretKind? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_SECRET" => GetDrainsResponseDrainsVariant1ItemDeliveryVariant1SecretKind.IntegrationSecret,
                _ => null,
            };
        }
    }
}