
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDrainResponseVariant2DeliveryVariant1SecretKind
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDrainResponseVariant2DeliveryVariant1SecretKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDrainResponseVariant2DeliveryVariant1SecretKind value)
        {
            return value switch
            {
                UpdateDrainResponseVariant2DeliveryVariant1SecretKind.IntegrationSecret => "INTEGRATION_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDrainResponseVariant2DeliveryVariant1SecretKind? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_SECRET" => UpdateDrainResponseVariant2DeliveryVariant1SecretKind.IntegrationSecret,
                _ => null,
            };
        }
    }
}