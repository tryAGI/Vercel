
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedc9c79e81839bbccdTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}