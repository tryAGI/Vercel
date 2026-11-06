
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedfa8b687d5ac48c48TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}