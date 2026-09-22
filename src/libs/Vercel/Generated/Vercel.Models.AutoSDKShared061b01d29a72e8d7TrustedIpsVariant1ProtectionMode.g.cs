
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared061b01d29a72e8d7TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}