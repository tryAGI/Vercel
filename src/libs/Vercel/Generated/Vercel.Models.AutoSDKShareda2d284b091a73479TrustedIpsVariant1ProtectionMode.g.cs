
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShareda2d284b091a73479TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}