
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharede052f139ff613de3TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}