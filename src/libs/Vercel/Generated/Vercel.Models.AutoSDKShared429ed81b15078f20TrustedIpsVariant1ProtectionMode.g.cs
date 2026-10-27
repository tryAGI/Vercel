
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared429ed81b15078f20TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}