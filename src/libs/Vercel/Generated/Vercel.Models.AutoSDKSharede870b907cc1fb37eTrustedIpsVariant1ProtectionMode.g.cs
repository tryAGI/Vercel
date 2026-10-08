
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharede870b907cc1fb37eTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}