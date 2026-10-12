
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbServiceServiceType
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
    public static class AutoSDKSharedba7c6b12ca723bfbServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Cron => "cron",
                AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Job => "job",
                AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Web => "web",
                AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Cron,
                "job" => AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Job,
                "web" => AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Web,
                "worker" => AutoSDKSharedba7c6b12ca723bfbServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}