
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DNSSECEnabledCode
    {
        /// <summary>
        /// 
        /// </summary>
        DnssecEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DNSSECEnabledCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DNSSECEnabledCode value)
        {
            return value switch
            {
                DNSSECEnabledCode.DnssecEnabled => "dnssec_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DNSSECEnabledCode? ToEnum(string value)
        {
            return value switch
            {
                "dnssec_enabled" => DNSSECEnabledCode.DnssecEnabled,
                _ => null,
            };
        }
    }
}