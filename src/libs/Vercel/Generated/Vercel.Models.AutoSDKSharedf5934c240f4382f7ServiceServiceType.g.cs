
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Service kind (Service.type). Omitted for schemas that do not define one.
    /// </summary>
    public enum AutoSDKSharedf5934c240f4382f7ServiceServiceType
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
    public static class AutoSDKSharedf5934c240f4382f7ServiceServiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf5934c240f4382f7ServiceServiceType value)
        {
            return value switch
            {
                AutoSDKSharedf5934c240f4382f7ServiceServiceType.Cron => "cron",
                AutoSDKSharedf5934c240f4382f7ServiceServiceType.Job => "job",
                AutoSDKSharedf5934c240f4382f7ServiceServiceType.Web => "web",
                AutoSDKSharedf5934c240f4382f7ServiceServiceType.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf5934c240f4382f7ServiceServiceType? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedf5934c240f4382f7ServiceServiceType.Cron,
                "job" => AutoSDKSharedf5934c240f4382f7ServiceServiceType.Job,
                "web" => AutoSDKSharedf5934c240f4382f7ServiceServiceType.Web,
                "worker" => AutoSDKSharedf5934c240f4382f7ServiceServiceType.Worker,
                _ => null,
            };
        }
    }
}