
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared2eb5520e92a3b839TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}