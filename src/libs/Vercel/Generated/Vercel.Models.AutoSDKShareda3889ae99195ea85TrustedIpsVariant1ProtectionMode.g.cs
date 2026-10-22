
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShareda3889ae99195ea85TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}