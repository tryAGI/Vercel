
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKShared7851faacb4798d73ServiceServiceType
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
    public static class AutoSDKShared7851faacb4798d73ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7851faacb4798d73ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKShared7851faacb4798d73ServiceServiceType.Cron => "cron",
                AutoSDKShared7851faacb4798d73ServiceServiceType.Job => "job",
                AutoSDKShared7851faacb4798d73ServiceServiceType.Web => "web",
                AutoSDKShared7851faacb4798d73ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7851faacb4798d73ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared7851faacb4798d73ServiceServiceType.Cron,
                "job" => AutoSDKShared7851faacb4798d73ServiceServiceType.Job,
                "web" => AutoSDKShared7851faacb4798d73ServiceServiceType.Web,
                "worker" => AutoSDKShared7851faacb4798d73ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}