
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AggregateEventsByItemEnum
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
        Day,
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
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Month,
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
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AggregateEventsByItemEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AggregateEventsByItemEnum value)
        {
            return value switch
            {
                AggregateEventsByItemEnum.BrowserName => "browserName",
                AggregateEventsByItemEnum.Country => "country",
                AggregateEventsByItemEnum.Day => "day",
                AggregateEventsByItemEnum.DeviceType => "deviceType",
                AggregateEventsByItemEnum.Environment => "environment",
                AggregateEventsByItemEnum.EventData => "eventData",
                AggregateEventsByItemEnum.EventName => "eventName",
                AggregateEventsByItemEnum.Flags => "flags",
                AggregateEventsByItemEnum.Hour => "hour",
                AggregateEventsByItemEnum.Month => "month",
                AggregateEventsByItemEnum.OsName => "osName",
                AggregateEventsByItemEnum.ReferrerHostname => "referrerHostname",
                AggregateEventsByItemEnum.RequestPath => "requestPath",
                AggregateEventsByItemEnum.Route => "route",
                AggregateEventsByItemEnum.UtmCampaign => "utmCampaign",
                AggregateEventsByItemEnum.UtmContent => "utmContent",
                AggregateEventsByItemEnum.UtmMedium => "utmMedium",
                AggregateEventsByItemEnum.UtmSource => "utmSource",
                AggregateEventsByItemEnum.UtmTerm => "utmTerm",
                AggregateEventsByItemEnum.Week => "week",
                AggregateEventsByItemEnum.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AggregateEventsByItemEnum? ToEnum(string value)
        {
            return value switch
            {
                "browserName" => AggregateEventsByItemEnum.BrowserName,
                "country" => AggregateEventsByItemEnum.Country,
                "day" => AggregateEventsByItemEnum.Day,
                "deviceType" => AggregateEventsByItemEnum.DeviceType,
                "environment" => AggregateEventsByItemEnum.Environment,
                "eventData" => AggregateEventsByItemEnum.EventData,
                "eventName" => AggregateEventsByItemEnum.EventName,
                "flags" => AggregateEventsByItemEnum.Flags,
                "hour" => AggregateEventsByItemEnum.Hour,
                "month" => AggregateEventsByItemEnum.Month,
                "osName" => AggregateEventsByItemEnum.OsName,
                "referrerHostname" => AggregateEventsByItemEnum.ReferrerHostname,
                "requestPath" => AggregateEventsByItemEnum.RequestPath,
                "route" => AggregateEventsByItemEnum.Route,
                "utmCampaign" => AggregateEventsByItemEnum.UtmCampaign,
                "utmContent" => AggregateEventsByItemEnum.UtmContent,
                "utmMedium" => AggregateEventsByItemEnum.UtmMedium,
                "utmSource" => AggregateEventsByItemEnum.UtmSource,
                "utmTerm" => AggregateEventsByItemEnum.UtmTerm,
                "week" => AggregateEventsByItemEnum.Week,
                "year" => AggregateEventsByItemEnum.Year,
                _ => null,
            };
        }
    }
}