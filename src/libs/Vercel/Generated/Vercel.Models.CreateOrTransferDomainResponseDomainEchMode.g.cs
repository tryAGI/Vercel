
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the domain is enrolled in Encrypted Client Hello. `auto` leaves the decision to Vercel, `enabled` always enrolls, and `disabled` never enrolls and opts out of automatic enrollment.<br/>
    /// Example: auto
    /// </summary>
    public enum CreateOrTransferDomainResponseDomainEchMode
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
    public static class CreateOrTransferDomainResponseDomainEchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrTransferDomainResponseDomainEchMode value)
        {
            return value switch
            {
                CreateOrTransferDomainResponseDomainEchMode.Auto => "auto",
                CreateOrTransferDomainResponseDomainEchMode.Disabled => "disabled",
                CreateOrTransferDomainResponseDomainEchMode.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrTransferDomainResponseDomainEchMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateOrTransferDomainResponseDomainEchMode.Auto,
                "disabled" => CreateOrTransferDomainResponseDomainEchMode.Disabled,
                "enabled" => CreateOrTransferDomainResponseDomainEchMode.Enabled,
                _ => null,
            };
        }
    }
}