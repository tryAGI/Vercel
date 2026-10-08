
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared7851faacb4798d73TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}