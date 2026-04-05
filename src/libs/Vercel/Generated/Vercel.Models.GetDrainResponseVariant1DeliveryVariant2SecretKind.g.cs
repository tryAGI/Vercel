
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainResponseVariant1DeliveryVariant2SecretKind
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDrainResponseVariant1DeliveryVariant2SecretKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainResponseVariant1DeliveryVariant2SecretKind value)
        {
            return value switch
            {
                GetDrainResponseVariant1DeliveryVariant2SecretKind.IntegrationSecret => "INTEGRATION_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainResponseVariant1DeliveryVariant2SecretKind? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_SECRET" => GetDrainResponseVariant1DeliveryVariant2SecretKind.IntegrationSecret,
                _ => null,
            };
        }
    }
}