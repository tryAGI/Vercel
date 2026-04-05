
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionMode
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
    public static class GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionMode.Additional => "additional",
                GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => GetMicrofrontendsInGroupResponseProjectTrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}