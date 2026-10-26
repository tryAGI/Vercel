
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared8b163ed62d2bb341TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}