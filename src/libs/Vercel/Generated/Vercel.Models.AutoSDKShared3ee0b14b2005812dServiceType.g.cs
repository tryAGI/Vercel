
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of service the domain is handled by. `external` if the DNS is externally handled, `zeit.world` if handled with Vercel, or `na` if the service is not available.<br/>
    /// Example: zeit.world
    /// </summary>
    public enum AutoSDKShared3ee0b14b2005812dServiceType
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
    public static class AutoSDKShared3ee0b14b2005812dServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3ee0b14b2005812dServiceType value)
        {
            return value switch
            {
                AutoSDKShared3ee0b14b2005812dServiceType.External => "external",
                AutoSDKShared3ee0b14b2005812dServiceType.Na => "na",
                AutoSDKShared3ee0b14b2005812dServiceType.ZeitWorld => "zeit.world",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3ee0b14b2005812dServiceType? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared3ee0b14b2005812dServiceType.External,
                "na" => AutoSDKShared3ee0b14b2005812dServiceType.Na,
                "zeit.world" => AutoSDKShared3ee0b14b2005812dServiceType.ZeitWorld,
                _ => null,
            };
        }
    }
}