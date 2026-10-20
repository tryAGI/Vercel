
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared6bf801e26ecd75afTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}