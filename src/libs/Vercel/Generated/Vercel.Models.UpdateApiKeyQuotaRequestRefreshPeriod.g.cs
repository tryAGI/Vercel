
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How often the quota refreshes.
    /// </summary>
    public enum UpdateApiKeyQuotaRequestRefreshPeriod
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Monthly,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Weekly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateApiKeyQuotaRequestRefreshPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateApiKeyQuotaRequestRefreshPeriod value)
        {
            return value switch
            {
                UpdateApiKeyQuotaRequestRefreshPeriod.Daily => "daily",
                UpdateApiKeyQuotaRequestRefreshPeriod.Monthly => "monthly",
                UpdateApiKeyQuotaRequestRefreshPeriod.None => "none",
                UpdateApiKeyQuotaRequestRefreshPeriod.Weekly => "weekly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateApiKeyQuotaRequestRefreshPeriod? ToEnum(string value)
        {
            return value switch
            {
                "daily" => UpdateApiKeyQuotaRequestRefreshPeriod.Daily,
                "monthly" => UpdateApiKeyQuotaRequestRefreshPeriod.Monthly,
                "none" => UpdateApiKeyQuotaRequestRefreshPeriod.None,
                "weekly" => UpdateApiKeyQuotaRequestRefreshPeriod.Weekly,
                _ => null,
            };
        }
    }
}