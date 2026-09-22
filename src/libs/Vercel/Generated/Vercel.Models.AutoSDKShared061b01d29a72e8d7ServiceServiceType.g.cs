
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared061b01d29a72e8d7ServiceServiceType
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
    public static class AutoSDKShared061b01d29a72e8d7ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared061b01d29a72e8d7ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared061b01d29a72e8d7ServiceServiceType.Cron => "cron",
                AutoSDKShared061b01d29a72e8d7ServiceServiceType.Job => "job",
                AutoSDKShared061b01d29a72e8d7ServiceServiceType.Web => "web",
                AutoSDKShared061b01d29a72e8d7ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared061b01d29a72e8d7ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared061b01d29a72e8d7ServiceServiceType.Cron,
                "job" => AutoSDKShared061b01d29a72e8d7ServiceServiceType.Job,
                "web" => AutoSDKShared061b01d29a72e8d7ServiceServiceType.Web,
                "worker" => AutoSDKShared061b01d29a72e8d7ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}