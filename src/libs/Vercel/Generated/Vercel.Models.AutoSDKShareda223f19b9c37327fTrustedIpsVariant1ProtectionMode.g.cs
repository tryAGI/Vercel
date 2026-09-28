
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShareda223f19b9c37327fTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}