
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared0d52d5fc16437df8TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}