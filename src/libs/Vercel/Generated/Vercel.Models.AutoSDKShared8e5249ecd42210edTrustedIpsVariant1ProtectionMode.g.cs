
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared8e5249ecd42210edTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}