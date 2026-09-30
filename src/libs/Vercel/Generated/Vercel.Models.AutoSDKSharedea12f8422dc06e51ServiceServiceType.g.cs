
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51ServiceServiceType
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
    public static class AutoSDKSharedea12f8422dc06e51ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51ServiceServiceType.Cron => "cron",
                AutoSDKSharedea12f8422dc06e51ServiceServiceType.Job => "job",
                AutoSDKSharedea12f8422dc06e51ServiceServiceType.Web => "web",
                AutoSDKSharedea12f8422dc06e51ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedea12f8422dc06e51ServiceServiceType.Cron,
                "job" => AutoSDKSharedea12f8422dc06e51ServiceServiceType.Job,
                "web" => AutoSDKSharedea12f8422dc06e51ServiceServiceType.Web,
                "worker" => AutoSDKSharedea12f8422dc06e51ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}