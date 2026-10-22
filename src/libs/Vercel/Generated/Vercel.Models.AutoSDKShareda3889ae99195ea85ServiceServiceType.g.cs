
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85ServiceServiceType
    {
        /// <summary>
        ///
        /// </summary>
        Cron,
        /// <summary>
        ///
        /// </summary>
        Job,
        /// <summary>
        ///
        /// </summary>
        Web,
        /// <summary>
        ///
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda3889ae99195ea85ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85ServiceServiceType.Cron => "cron",
                AutoSDKShareda3889ae99195ea85ServiceServiceType.Job => "job",
                AutoSDKShareda3889ae99195ea85ServiceServiceType.Web => "web",
                AutoSDKShareda3889ae99195ea85ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShareda3889ae99195ea85ServiceServiceType.Cron,
                "job" => AutoSDKShareda3889ae99195ea85ServiceServiceType.Job,
                "web" => AutoSDKShareda3889ae99195ea85ServiceServiceType.Web,
                "worker" => AutoSDKShareda3889ae99195ea85ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}