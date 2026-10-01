
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharede27e7ff1aa86f19eTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}