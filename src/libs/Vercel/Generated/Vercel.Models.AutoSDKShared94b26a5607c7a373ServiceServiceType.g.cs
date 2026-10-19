
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373ServiceServiceType
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
    public static class AutoSDKShared94b26a5607c7a373ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373ServiceServiceType.Cron => "cron",
                AutoSDKShared94b26a5607c7a373ServiceServiceType.Job => "job",
                AutoSDKShared94b26a5607c7a373ServiceServiceType.Web => "web",
                AutoSDKShared94b26a5607c7a373ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared94b26a5607c7a373ServiceServiceType.Cron,
                "job" => AutoSDKShared94b26a5607c7a373ServiceServiceType.Job,
                "web" => AutoSDKShared94b26a5607c7a373ServiceServiceType.Web,
                "worker" => AutoSDKShared94b26a5607c7a373ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}