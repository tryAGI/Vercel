
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34ServiceServiceType
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
    public static class AutoSDKShared4d5a5876dd584f34ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34ServiceServiceType.Cron => "cron",
                AutoSDKShared4d5a5876dd584f34ServiceServiceType.Job => "job",
                AutoSDKShared4d5a5876dd584f34ServiceServiceType.Web => "web",
                AutoSDKShared4d5a5876dd584f34ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared4d5a5876dd584f34ServiceServiceType.Cron,
                "job" => AutoSDKShared4d5a5876dd584f34ServiceServiceType.Job,
                "web" => AutoSDKShared4d5a5876dd584f34ServiceServiceType.Web,
                "worker" => AutoSDKShared4d5a5876dd584f34ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}