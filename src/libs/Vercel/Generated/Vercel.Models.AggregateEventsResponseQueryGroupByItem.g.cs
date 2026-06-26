
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AggregateEventsResponseQueryGroupByItem
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
        EventData,
        /// <summary>
        /// 
        /// </summary>
        EventName,
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
    public static class AggregateEventsResponseQueryGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AggregateEventsResponseQueryGroupByItem value)
        {
            return value switch
            {
                AggregateEventsResponseQueryGroupByItem.BrowserName => "browserName",
                AggregateEventsResponseQueryGroupByItem.Country => "country",
                AggregateEventsResponseQueryGroupByItem.DeviceType => "deviceType",
                AggregateEventsResponseQueryGroupByItem.Environment => "environment",
                AggregateEventsResponseQueryGroupByItem.EventData => "eventData",
                AggregateEventsResponseQueryGroupByItem.EventName => "eventName",
                AggregateEventsResponseQueryGroupByItem.Flags => "flags",
                AggregateEventsResponseQueryGroupByItem.OsName => "osName",
                AggregateEventsResponseQueryGroupByItem.ReferrerHostname => "referrerHostname",
                AggregateEventsResponseQueryGroupByItem.RequestPath => "requestPath",
                AggregateEventsResponseQueryGroupByItem.Route => "route",
                AggregateEventsResponseQueryGroupByItem.UtmCampaign => "utmCampaign",
                AggregateEventsResponseQueryGroupByItem.UtmContent => "utmContent",
                AggregateEventsResponseQueryGroupByItem.UtmMedium => "utmMedium",
                AggregateEventsResponseQueryGroupByItem.UtmSource => "utmSource",
                AggregateEventsResponseQueryGroupByItem.UtmTerm => "utmTerm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AggregateEventsResponseQueryGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "browserName" => AggregateEventsResponseQueryGroupByItem.BrowserName,
                "country" => AggregateEventsResponseQueryGroupByItem.Country,
                "deviceType" => AggregateEventsResponseQueryGroupByItem.DeviceType,
                "environment" => AggregateEventsResponseQueryGroupByItem.Environment,
                "eventData" => AggregateEventsResponseQueryGroupByItem.EventData,
                "eventName" => AggregateEventsResponseQueryGroupByItem.EventName,
                "flags" => AggregateEventsResponseQueryGroupByItem.Flags,
                "osName" => AggregateEventsResponseQueryGroupByItem.OsName,
                "referrerHostname" => AggregateEventsResponseQueryGroupByItem.ReferrerHostname,
                "requestPath" => AggregateEventsResponseQueryGroupByItem.RequestPath,
                "route" => AggregateEventsResponseQueryGroupByItem.Route,
                "utmCampaign" => AggregateEventsResponseQueryGroupByItem.UtmCampaign,
                "utmContent" => AggregateEventsResponseQueryGroupByItem.UtmContent,
                "utmMedium" => AggregateEventsResponseQueryGroupByItem.UtmMedium,
                "utmSource" => AggregateEventsResponseQueryGroupByItem.UtmSource,
                "utmTerm" => AggregateEventsResponseQueryGroupByItem.UtmTerm,
                _ => null,
            };
        }
    }
}