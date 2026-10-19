
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared94b26a5607c7a373TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}