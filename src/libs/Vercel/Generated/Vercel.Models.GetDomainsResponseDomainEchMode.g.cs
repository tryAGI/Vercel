
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the domain is enrolled in Encrypted Client Hello. `auto` leaves the decision to Vercel, `enabled` always enrolls, and `disabled` never enrolls and opts out of automatic enrollment.<br/>
    /// Example: auto
    /// </summary>
    public enum GetDomainsResponseDomainEchMode
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
    public static class GetDomainsResponseDomainEchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainsResponseDomainEchMode value)
        {
            return value switch
            {
                GetDomainsResponseDomainEchMode.Auto => "auto",
                GetDomainsResponseDomainEchMode.Disabled => "disabled",
                GetDomainsResponseDomainEchMode.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainsResponseDomainEchMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetDomainsResponseDomainEchMode.Auto,
                "disabled" => GetDomainsResponseDomainEchMode.Disabled,
                "enabled" => GetDomainsResponseDomainEchMode.Enabled,
                _ => null,
            };
        }
    }
}