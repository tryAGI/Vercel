
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionMode
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
    public static class UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionMode.Additional => "additional",
                UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => UpdateMicrofrontendsResponseTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}