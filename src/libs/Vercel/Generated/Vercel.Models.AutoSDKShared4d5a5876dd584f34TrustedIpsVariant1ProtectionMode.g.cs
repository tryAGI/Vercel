
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionMode
    {
        /// <summary>
        ///
        /// </summary>
        Additional,
        /// <summary>
        ///
        /// </summary>
        Exclusive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared4d5a5876dd584f34TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}