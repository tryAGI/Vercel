
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseTrustedIpsVariant1ProtectionMode
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
    public static class GetProjectResponseTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                GetProjectResponseTrustedIpsVariant1ProtectionMode.Additional => "additional",
                GetProjectResponseTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => GetProjectResponseTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => GetProjectResponseTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}