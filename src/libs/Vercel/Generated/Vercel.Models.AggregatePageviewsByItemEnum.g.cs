
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AggregatePageviewsByItemEnum
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
    public static class AggregatePageviewsByItemEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AggregatePageviewsByItemEnum value)
        {
            return value switch
            {
                AggregatePageviewsByItemEnum.BrowserName => "browserName",
                AggregatePageviewsByItemEnum.Country => "country",
                AggregatePageviewsByItemEnum.Day => "day",
                AggregatePageviewsByItemEnum.DeviceType => "deviceType",
                AggregatePageviewsByItemEnum.Environment => "environment",
                AggregatePageviewsByItemEnum.Flags => "flags",
                AggregatePageviewsByItemEnum.Hour => "hour",
                AggregatePageviewsByItemEnum.Month => "month",
                AggregatePageviewsByItemEnum.OsName => "osName",
                AggregatePageviewsByItemEnum.ReferrerHostname => "referrerHostname",
                AggregatePageviewsByItemEnum.RequestPath => "requestPath",
                AggregatePageviewsByItemEnum.Route => "route",
                AggregatePageviewsByItemEnum.UtmCampaign => "utmCampaign",
                AggregatePageviewsByItemEnum.UtmContent => "utmContent",
                AggregatePageviewsByItemEnum.UtmMedium => "utmMedium",
                AggregatePageviewsByItemEnum.UtmSource => "utmSource",
                AggregatePageviewsByItemEnum.UtmTerm => "utmTerm",
                AggregatePageviewsByItemEnum.Week => "week",
                AggregatePageviewsByItemEnum.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AggregatePageviewsByItemEnum? ToEnum(string value)
        {
            return value switch
            {
                "browserName" => AggregatePageviewsByItemEnum.BrowserName,
                "country" => AggregatePageviewsByItemEnum.Country,
                "day" => AggregatePageviewsByItemEnum.Day,
                "deviceType" => AggregatePageviewsByItemEnum.DeviceType,
                "environment" => AggregatePageviewsByItemEnum.Environment,
                "flags" => AggregatePageviewsByItemEnum.Flags,
                "hour" => AggregatePageviewsByItemEnum.Hour,
                "month" => AggregatePageviewsByItemEnum.Month,
                "osName" => AggregatePageviewsByItemEnum.OsName,
                "referrerHostname" => AggregatePageviewsByItemEnum.ReferrerHostname,
                "requestPath" => AggregatePageviewsByItemEnum.RequestPath,
                "route" => AggregatePageviewsByItemEnum.Route,
                "utmCampaign" => AggregatePageviewsByItemEnum.UtmCampaign,
                "utmContent" => AggregatePageviewsByItemEnum.UtmContent,
                "utmMedium" => AggregatePageviewsByItemEnum.UtmMedium,
                "utmSource" => AggregatePageviewsByItemEnum.UtmSource,
                "utmTerm" => AggregatePageviewsByItemEnum.UtmTerm,
                "week" => AggregatePageviewsByItemEnum.Week,
                "year" => AggregatePageviewsByItemEnum.Year,
                _ => null,
            };
        }
    }
}