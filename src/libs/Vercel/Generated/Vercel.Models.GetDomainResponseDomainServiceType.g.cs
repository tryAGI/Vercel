
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of service the domain is handled by. `external` if the DNS is externally handled, `zeit.world` if handled with Vercel, or `na` if the service is not available.<br/>
    /// Example: zeit.world
    /// </summary>
    public enum GetDomainResponseDomainServiceType
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
    public static class GetDomainResponseDomainServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainResponseDomainServiceType value)
        {
            return value switch
            {
                GetDomainResponseDomainServiceType.External => "external",
                GetDomainResponseDomainServiceType.Na => "na",
                GetDomainResponseDomainServiceType.ZeitWorld => "zeit.world",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainResponseDomainServiceType? ToEnum(string value)
        {
            return value switch
            {
                "external" => GetDomainResponseDomainServiceType.External,
                "na" => GetDomainResponseDomainServiceType.Na,
                "zeit.world" => GetDomainResponseDomainServiceType.ZeitWorld,
                _ => null,
            };
        }
    }
}