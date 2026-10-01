
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallEventsSort
    {
        /// <summary>
        ///
        /// </summary>
        StartTime_asc,
        /// <summary>
        ///
        /// </summary>
        StartTime_desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSecurityFirewallEventsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallEventsSort value)
        {
            return value switch
            {
                GetSecurityFirewallEventsSort.StartTime_asc => "startTime:asc",
                GetSecurityFirewallEventsSort.StartTime_desc => "startTime:desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallEventsSort? ToEnum(string value)
        {
            return value switch
            {
                "startTime:asc" => GetSecurityFirewallEventsSort.StartTime_asc,
                "startTime:desc" => GetSecurityFirewallEventsSort.StartTime_desc,
                _ => null,
            };
        }
    }
}