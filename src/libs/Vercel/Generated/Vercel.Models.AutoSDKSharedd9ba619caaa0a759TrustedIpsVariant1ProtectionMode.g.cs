
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedd9ba619caaa0a759TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}