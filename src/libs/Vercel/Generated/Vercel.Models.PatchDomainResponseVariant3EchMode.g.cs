
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchDomainResponseVariant3EchMode
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
    public static class PatchDomainResponseVariant3EchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchDomainResponseVariant3EchMode value)
        {
            return value switch
            {
                PatchDomainResponseVariant3EchMode.Auto => "auto",
                PatchDomainResponseVariant3EchMode.Disabled => "disabled",
                PatchDomainResponseVariant3EchMode.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchDomainResponseVariant3EchMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PatchDomainResponseVariant3EchMode.Auto,
                "disabled" => PatchDomainResponseVariant3EchMode.Disabled,
                "enabled" => PatchDomainResponseVariant3EchMode.Enabled,
                _ => null,
            };
        }
    }
}