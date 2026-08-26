
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Encrypted Client Hello enrollment. 'auto' leaves it to Vercel, 'enabled' always enrolls, 'disabled' never enrolls and opts out of automatic enrollment.
    /// </summary>
    public enum PatchDomainRequestVariant1EchMode
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchDomainRequestVariant1EchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchDomainRequestVariant1EchMode value)
        {
            return value switch
            {
                PatchDomainRequestVariant1EchMode.Auto => "auto",
                PatchDomainRequestVariant1EchMode.Disabled => "disabled",
                PatchDomainRequestVariant1EchMode.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchDomainRequestVariant1EchMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PatchDomainRequestVariant1EchMode.Auto,
                "disabled" => PatchDomainRequestVariant1EchMode.Disabled,
                "enabled" => PatchDomainRequestVariant1EchMode.Enabled,
                _ => null,
            };
        }
    }
}