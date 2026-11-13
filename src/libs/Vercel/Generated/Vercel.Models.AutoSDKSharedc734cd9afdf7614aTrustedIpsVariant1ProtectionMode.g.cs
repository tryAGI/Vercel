
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedc734cd9afdf7614aTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}