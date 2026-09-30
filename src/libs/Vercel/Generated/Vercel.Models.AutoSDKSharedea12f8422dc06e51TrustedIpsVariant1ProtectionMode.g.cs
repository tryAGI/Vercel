
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedea12f8422dc06e51TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}