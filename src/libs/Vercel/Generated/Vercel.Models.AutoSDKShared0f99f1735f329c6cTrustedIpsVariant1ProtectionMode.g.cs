
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared0f99f1735f329c6cTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}