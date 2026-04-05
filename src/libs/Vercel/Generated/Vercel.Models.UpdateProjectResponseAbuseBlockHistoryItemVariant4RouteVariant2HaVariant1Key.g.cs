
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key
    {
        /// <summary>
        /// 
        /// </summary>
        XVercelIpCountry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1KeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key value)
        {
            return value switch
            {
                UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key.XVercelIpCountry => "x-vercel-ip-country",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key? ToEnum(string value)
        {
            return value switch
            {
                "x-vercel-ip-country" => UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key.XVercelIpCountry,
                _ => null,
            };
        }
    }
}