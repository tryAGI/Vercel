
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of service the domain is handled by. `external` if the DNS is externally handled, `zeit.world` if handled with Vercel, or `na` if the service is not available.<br/>
    /// Example: zeit.world
    /// </summary>
    public enum CreateOrTransferDomainResponseDomainServiceType
    {
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        Na,
        /// <summary>
        /// 
        /// </summary>
        ZeitWorld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrTransferDomainResponseDomainServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrTransferDomainResponseDomainServiceType value)
        {
            return value switch
            {
                CreateOrTransferDomainResponseDomainServiceType.External => "external",
                CreateOrTransferDomainResponseDomainServiceType.Na => "na",
                CreateOrTransferDomainResponseDomainServiceType.ZeitWorld => "zeit.world",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrTransferDomainResponseDomainServiceType? ToEnum(string value)
        {
            return value switch
            {
                "external" => CreateOrTransferDomainResponseDomainServiceType.External,
                "na" => CreateOrTransferDomainResponseDomainServiceType.Na,
                "zeit.world" => CreateOrTransferDomainResponseDomainServiceType.ZeitWorld,
                _ => null,
            };
        }
    }
}