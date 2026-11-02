
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedf5934c240f4382f7TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}