
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared39497871754bda72ServiceServiceType
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
    public static class AutoSDKShared39497871754bda72ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72ServiceServiceType.Cron => "cron",
                AutoSDKShared39497871754bda72ServiceServiceType.Job => "job",
                AutoSDKShared39497871754bda72ServiceServiceType.Web => "web",
                AutoSDKShared39497871754bda72ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared39497871754bda72ServiceServiceType.Cron,
                "job" => AutoSDKShared39497871754bda72ServiceServiceType.Job,
                "web" => AutoSDKShared39497871754bda72ServiceServiceType.Web,
                "worker" => AutoSDKShared39497871754bda72ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}