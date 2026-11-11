
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedc1c2f92d02e0feb6TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}