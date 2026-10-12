
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedba7c6b12ca723bfbTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}