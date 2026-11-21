
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared1134f969ff3cc06cTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}