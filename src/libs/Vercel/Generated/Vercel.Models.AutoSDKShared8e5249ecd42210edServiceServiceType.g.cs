
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared8e5249ecd42210edServiceServiceType
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
    public static class AutoSDKShared8e5249ecd42210edServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8e5249ecd42210edServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared8e5249ecd42210edServiceServiceType.Cron => "cron",
                AutoSDKShared8e5249ecd42210edServiceServiceType.Job => "job",
                AutoSDKShared8e5249ecd42210edServiceServiceType.Web => "web",
                AutoSDKShared8e5249ecd42210edServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8e5249ecd42210edServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared8e5249ecd42210edServiceServiceType.Cron,
                "job" => AutoSDKShared8e5249ecd42210edServiceServiceType.Job,
                "web" => AutoSDKShared8e5249ecd42210edServiceServiceType.Web,
                "worker" => AutoSDKShared8e5249ecd42210edServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}