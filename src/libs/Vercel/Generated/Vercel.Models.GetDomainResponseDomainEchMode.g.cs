
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the domain is enrolled in Encrypted Client Hello. `auto` leaves the decision to Vercel, `enabled` always enrolls, and `disabled` never enrolls and opts out of automatic enrollment.<br/>
    /// Example: auto
    /// </summary>
    public enum GetDomainResponseDomainEchMode
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
    public static class GetDomainResponseDomainEchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainResponseDomainEchMode value)
        {
            return value switch
            {
                GetDomainResponseDomainEchMode.Auto => "auto",
                GetDomainResponseDomainEchMode.Disabled => "disabled",
                GetDomainResponseDomainEchMode.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainResponseDomainEchMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetDomainResponseDomainEchMode.Auto,
                "disabled" => GetDomainResponseDomainEchMode.Disabled,
                "enabled" => GetDomainResponseDomainEchMode.Enabled,
                _ => null,
            };
        }
    }
}