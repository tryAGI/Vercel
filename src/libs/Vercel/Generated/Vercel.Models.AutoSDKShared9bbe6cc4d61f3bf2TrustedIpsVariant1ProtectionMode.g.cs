
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared9bbe6cc4d61f3bf2TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}