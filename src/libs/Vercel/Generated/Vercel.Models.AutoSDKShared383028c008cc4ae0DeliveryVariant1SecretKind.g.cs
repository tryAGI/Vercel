
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared383028c008cc4ae0DeliveryVariant1SecretKind
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared383028c008cc4ae0DeliveryVariant1SecretKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared383028c008cc4ae0DeliveryVariant1SecretKind value)
        {
            return value switch
            {
                AutoSDKShared383028c008cc4ae0DeliveryVariant1SecretKind.IntegrationSecret => "INTEGRATION_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared383028c008cc4ae0DeliveryVariant1SecretKind? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_SECRET" => AutoSDKShared383028c008cc4ae0DeliveryVariant1SecretKind.IntegrationSecret,
                _ => null,
            };
        }
    }
}