
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key
    {
        /// <summary>
        /// 
        /// </summary>
        XVercelIpCountry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1KeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key.XVercelIpCountry => "x-vercel-ip-country",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key? ToEnum(string value)
        {
            return value switch
            {
                "x-vercel-ip-country" => GetProjectsResponseVariant3ProjectAbuseBlockHistoryItemVariant4RouteVariant2HaVariant1Key.XVercelIpCountry,
                _ => null,
            };
        }
    }
}