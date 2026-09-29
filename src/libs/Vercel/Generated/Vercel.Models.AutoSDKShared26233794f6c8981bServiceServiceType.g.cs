
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bServiceServiceType
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
    public static class AutoSDKShared26233794f6c8981bServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bServiceServiceType.Cron => "cron",
                AutoSDKShared26233794f6c8981bServiceServiceType.Job => "job",
                AutoSDKShared26233794f6c8981bServiceServiceType.Web => "web",
                AutoSDKShared26233794f6c8981bServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared26233794f6c8981bServiceServiceType.Cron,
                "job" => AutoSDKShared26233794f6c8981bServiceServiceType.Job,
                "web" => AutoSDKShared26233794f6c8981bServiceServiceType.Web,
                "worker" => AutoSDKShared26233794f6c8981bServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}