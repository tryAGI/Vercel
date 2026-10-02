
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedfe1f84289679c6c4TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}