
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2SecretKind
    {
        /// <summary>
        ///
        /// </summary>
        IntegrationSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2SecretKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2SecretKind value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2SecretKind.IntegrationSecret => "INTEGRATION_SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2SecretKind? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_SECRET" => AutoSDKSharedd5d6c9ab94c25f66DeliveryVariant2SecretKind.IntegrationSecret,
                _ => null,
            };
        }
    }
}