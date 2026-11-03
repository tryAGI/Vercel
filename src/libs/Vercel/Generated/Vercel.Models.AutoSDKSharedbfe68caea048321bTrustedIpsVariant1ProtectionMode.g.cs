
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode
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
    public static class AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKSharedbfe68caea048321bTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}