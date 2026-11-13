
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cServiceServiceType
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
    public static class AutoSDKShared0f99f1735f329c6cServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cServiceServiceType.Cron => "cron",
                AutoSDKShared0f99f1735f329c6cServiceServiceType.Job => "job",
                AutoSDKShared0f99f1735f329c6cServiceServiceType.Web => "web",
                AutoSDKShared0f99f1735f329c6cServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared0f99f1735f329c6cServiceServiceType.Cron,
                "job" => AutoSDKShared0f99f1735f329c6cServiceServiceType.Job,
                "web" => AutoSDKShared0f99f1735f329c6cServiceServiceType.Web,
                "worker" => AutoSDKShared0f99f1735f329c6cServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}