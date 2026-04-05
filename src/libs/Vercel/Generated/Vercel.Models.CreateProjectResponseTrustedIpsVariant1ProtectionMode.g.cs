
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseTrustedIpsVariant1ProtectionMode
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
    public static class CreateProjectResponseTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                CreateProjectResponseTrustedIpsVariant1ProtectionMode.Additional => "additional",
                CreateProjectResponseTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => CreateProjectResponseTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => CreateProjectResponseTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}