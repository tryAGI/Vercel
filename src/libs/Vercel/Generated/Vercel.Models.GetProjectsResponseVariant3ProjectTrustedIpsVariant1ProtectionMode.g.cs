
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionMode
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
    public static class GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionMode.Additional => "additional",
                GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => GetProjectsResponseVariant3ProjectTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}