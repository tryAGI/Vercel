
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedbe3f0c688bc34a31TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}