
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AggregatePageviewsResponseQueryGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        BrowserName,
        /// <summary>
        /// 
        /// </summary>
        Country,
        /// <summary>
        /// 
        /// </summary>
        DeviceType,
        /// <summary>
        /// 
        /// </summary>
        Environment,
        /// <summary>
        /// 
        /// </summary>
        Flags,
        /// <summary>
        /// 
        /// </summary>
        OsName,
        /// <summary>
        /// 
        /// </summary>
        ReferrerHostname,
        /// <summary>
        /// 
        /// </summary>
        RequestPath,
        /// <summary>
        /// 
        /// </summary>
        Route,
        /// <summary>
        /// 
        /// </summary>
        UtmCampaign,
        /// <summary>
        /// 
        /// </summary>
        UtmContent,
        /// <summary>
        /// 
        /// </summary>
        UtmMedium,
        /// <summary>
        /// 
        /// </summary>
        UtmSource,
        /// <summary>
        /// 
        /// </summary>
        UtmTerm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AggregatePageviewsResponseQueryGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AggregatePageviewsResponseQueryGroupByItem value)
        {
            return value switch
            {
                AggregatePageviewsResponseQueryGroupByItem.BrowserName => "browserName",
                AggregatePageviewsResponseQueryGroupByItem.Country => "country",
                AggregatePageviewsResponseQueryGroupByItem.DeviceType => "deviceType",
                AggregatePageviewsResponseQueryGroupByItem.Environment => "environment",
                AggregatePageviewsResponseQueryGroupByItem.Flags => "flags",
                AggregatePageviewsResponseQueryGroupByItem.OsName => "osName",
                AggregatePageviewsResponseQueryGroupByItem.ReferrerHostname => "referrerHostname",
                AggregatePageviewsResponseQueryGroupByItem.RequestPath => "requestPath",
                AggregatePageviewsResponseQueryGroupByItem.Route => "route",
                AggregatePageviewsResponseQueryGroupByItem.UtmCampaign => "utmCampaign",
                AggregatePageviewsResponseQueryGroupByItem.UtmContent => "utmContent",
                AggregatePageviewsResponseQueryGroupByItem.UtmMedium => "utmMedium",
                AggregatePageviewsResponseQueryGroupByItem.UtmSource => "utmSource",
                AggregatePageviewsResponseQueryGroupByItem.UtmTerm => "utmTerm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AggregatePageviewsResponseQueryGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "browserName" => AggregatePageviewsResponseQueryGroupByItem.BrowserName,
                "country" => AggregatePageviewsResponseQueryGroupByItem.Country,
                "deviceType" => AggregatePageviewsResponseQueryGroupByItem.DeviceType,
                "environment" => AggregatePageviewsResponseQueryGroupByItem.Environment,
                "flags" => AggregatePageviewsResponseQueryGroupByItem.Flags,
                "osName" => AggregatePageviewsResponseQueryGroupByItem.OsName,
                "referrerHostname" => AggregatePageviewsResponseQueryGroupByItem.ReferrerHostname,
                "requestPath" => AggregatePageviewsResponseQueryGroupByItem.RequestPath,
                "route" => AggregatePageviewsResponseQueryGroupByItem.Route,
                "utmCampaign" => AggregatePageviewsResponseQueryGroupByItem.UtmCampaign,
                "utmContent" => AggregatePageviewsResponseQueryGroupByItem.UtmContent,
                "utmMedium" => AggregatePageviewsResponseQueryGroupByItem.UtmMedium,
                "utmSource" => AggregatePageviewsResponseQueryGroupByItem.UtmSource,
                "utmTerm" => AggregatePageviewsResponseQueryGroupByItem.UtmTerm,
                _ => null,
            };
        }
    }
}